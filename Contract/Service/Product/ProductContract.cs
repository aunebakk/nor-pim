using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SolutionNorSolutionPim.BusinessLogicLayer
{
    [DataContract()]
    public class ProductDetailsContract
    {
        [DataMember()]
        public CrudeProductContract Product { get; set; }

        [DataMember()]
        public List<ProductMaintenanceAttributeIndexWithFilterContract> ProductMaintenanceAttributeIndexWithFilter { get; set; }

        [DataMember()]
        public List<ProductMaintenanceDocumentationIndexWithFilterContract> ProductMaintenanceDocumentationIndexWithFilter { get; set; }

        [DataMember()]
        public List<ProductMaintenanceIdentifierIndexWithFilterContract> ProductMaintenanceIdentifierIndexWithFilter { get; set; }

        [DataMember()]
        public List<ProductMaintenanceImageIndexWithFilterContract> ProductMaintenanceImageIndexWithFilter { get; set; }

        [DataMember()]
        public List<ProductMaintenanceInfoIndexWithFilterContract> ProductMaintenanceInfoIndexWithFilter { get; set; }
    }
}
