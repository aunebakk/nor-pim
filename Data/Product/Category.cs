using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace SolutionNorSolutionPim.DataAccessLayer
{
    [Serializable()]
    public class Category
    {
        public CrudeProductCategoryData ProductCategory;
        public List<CrudeProductCategoryImageData> ProductCategoryImage { get; set; }
        public List<CrudeProductCategoryDocumentationData> ProductCategoryDocumentation { get; set; }

        public Category(Guid productCategoryId) {

            // category base info
            ProductCategory = new CrudeProductCategoryData();
            ProductCategory.FetchByProductCategoryId(productCategoryId);

            // category images
            //var crudeImage = new CrudeProductCategoryImageData();
            ProductCategoryImage = CrudeProductCategoryImageData.FetchByProductCategoryId(productCategoryId);

            // category documentation
            //var crudeDocumentation = new CrudeProductCategoryDocumentationData();
            ProductCategoryDocumentation = CrudeProductCategoryDocumentationData.FetchByProductCategoryId(productCategoryId);
        }
    }

    public partial class CrudeProductCategoryData
    {

        public List<CrudeProductCategoryData> FetchTopLevel() {
            var dataList = new List<CrudeProductCategoryData>();

            string sql = @" 
                            select product_category_id, product_category_became_id, product_category_parent_id, product_category_code, product_category_name, product_category_position, state_rcd, user_id, date_time
                            from product_category as pc
                            where pc.product_category_id = pc.product_category_parent_id
                             and pc.product_category_became_id is null
                            order by pc.product_category_position
                            ";

            using ( var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"]) ) {
                conn.Open();

                using ( var command = new SqlCommand(sql, conn) ) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while ( reader.Read() ) {
                        var data = new CrudeProductCategoryData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }

                return dataList;
            }
        }

        public void FetchPreviousProductCategoryByPosition(Guid productCategoryParentId,
                                                            long position
                                                            ) {

            string sql = @" 
                            select top 1 product_category_id, product_category_became_id, product_category_parent_id, product_category_code, product_category_name, product_category_position, user_id, date_time, state_rcd
                            from product_category as pc
                            where pc.product_category_parent_id = @product_category_parent_id
                                and pc.product_category_became_id is null
	                            and pc.product_category_position < @position
                            order by pc.product_category_position desc
                            ";

            using ( var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"]) ) {
                conn.Open();

                using ( var command = new SqlCommand(sql, conn) ) {
                    command.Parameters.Add("@product_category_parent_id", SqlDbType.UniqueIdentifier).Value = productCategoryParentId;
                    command.Parameters.Add("@position", SqlDbType.Int).Value = position;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    if ( reader.Read() )
                        Populate(reader);
                }
            }
        }

        public void FetchNextProductCategoryByPosition(Guid productCategoryParentId,
                                                        long position
                                                        ) {

            string sql = @" 
                            select top 1 product_category_id, product_category_became_id, product_category_parent_id, product_category_code, product_category_name, product_category_position, user_id, date_time, state_rcd
                            from product_category as pc
                            where pc.product_category_parent_id = @product_category_parent_id
                                and pc.product_category_became_id is null
	                            and pc.product_category_position > @position
                            order by pc.product_category_position
                            ";

            using ( var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"]) ) {
                conn.Open();

                using ( var command = new SqlCommand(sql, conn) ) {
                    command.Parameters.Add("@product_category_parent_id", SqlDbType.UniqueIdentifier).Value = productCategoryParentId;
                    command.Parameters.Add("@position", SqlDbType.Int).Value = position;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    if ( reader.Read() )
                        Populate(reader);
                }
            }
        }

        public void GetByProductCategoryCode(string productCategoryCode
                                             ) {

            // override this to check became 
            string sql = @" 
                            select top 1 
                                         pc.product_category_id
                                        ,pc.product_category_became_id
                                        ,pc.product_category_parent_id
                                        ,pc.product_category_code
                                        ,pc.product_category_name
                                        ,pc.product_category_position
                                        ,pc.user_id
                                        ,pc.date_time
                                        ,pc.state_rcd
                            from product_category as pc
                            where product_category_code = @productCategoryCode
                              and product_category_became_id is null
                            ";

            using ( var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"]) ) {
                conn.Open();

                SqlCommand command = new SqlCommand(sql, conn);

                command.Parameters.Add("@productCategoryCode", SqlDbType.NVarChar).Value = productCategoryCode;

                IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                if ( reader.Read() )
                    Populate(reader);
            }
        }

        public static void InsertNewCategoryMapping(SqlConnection connection,
                                                    SqlTransaction transaction,
                                                    Guid productIdOld,
                                                    Guid productIdNew,
                                                    Guid userId
                                                    ) {
            string sql = @" 
                            insert into product_category_mapping (  product_category_mapping_id, 
                                                                    product_id, 
                                                                    product_category_id, 
                                                                    user_id, 
                                                                    date_time
                                                                    )
                            select 
	                            newid(),
	                            @product_id_new,
	                            cpm.product_category_id,
                                @user_id,
                                getutcdate()   
                            from product_category_mapping as cpm
                            where cpm.product_id = @product_id_old
                            ";

            using ( SqlCommand command = new SqlCommand(sql, connection, transaction) ) {
                command.Parameters.Add("@product_id_old", SqlDbType.UniqueIdentifier).Value = productIdOld;
                command.Parameters.Add("@product_id_new", SqlDbType.UniqueIdentifier).Value = productIdNew;
                command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;
                command.ExecuteNonQuery();
            }
        }

    }
}
