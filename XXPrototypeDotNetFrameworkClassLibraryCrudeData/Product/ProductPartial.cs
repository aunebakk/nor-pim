using System;
using System.Data;
using System.Data.SqlClient;

namespace SolutionNorSolutionPim.DataAccessLayer
{

    public partial class CrudeProductData
    {
        public void UpdateBecame(SqlConnection connection, SqlTransaction transaction) {
            string sql = @" update [product] set
                            product_became_id = @product_became_id
                            where product_id = @product_id";

            using ( SqlCommand command = new SqlCommand(sql, connection, transaction) ) {
                command.Parameters.Add("@product_id", SqlDbType.UniqueIdentifier).Value = ( ProductId == Guid.Empty ? ( object ) DBNull.Value : ( System.Guid ) ProductId );
                command.Parameters.Add("@product_became_id", SqlDbType.UniqueIdentifier).Value = ( ProductBecameId == Guid.Empty ? ( object ) DBNull.Value : ( System.Guid ) ProductBecameId );
                command.ExecuteNonQuery();
            }
        }
    }
}
