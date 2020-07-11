using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SolutionNorSolutionPim.BusinessLogicLayer
{
    [DataContract()]
    public class ProductCategoryContract
    {
        [DataMember()]
        public CrudeProductCategoryContract ProductCategory { get; set; }

        [DataMember()]
        public List<CrudeProductCategoryImageContract> ProductCategoryImage { get; set; }

        [DataMember()]
        public List<CrudeProductCategoryDocumentationContract> ProductCategoryDocumentation { get; set; }
    }
}
