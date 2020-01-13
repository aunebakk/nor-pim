using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SolutionNorSolutionPim.BusinessLogicLayer
{
    [DataContract()]
    public class ProductChangeEntityDetailContract
    {

        [DataMember()]
        public string ProductEntityTypeRcd { get; set; }

        [DataMember()]
        public string ProductEntityRcd { get; set; }

        [DataMember()]
        public string ProductEntityOldValue { get; set; }

        [DataMember()]
        public string ProductEntityNewValue { get; set; }
    }

    [DataContract()]
    public class ProductChangeEntityContract
    {
        [DataMember()]
        public Guid ProductId { get; set; }

        [DataMember()]
        public List<ProductChangeEntityDetailContract> EntityChanges { get; set; }
    }

    [DataContract()]
    public class ProductContract
    {
        [DataMember()]
        public CrudeProductContract Product { get; set; }

        [DataMember()]
        public List<CrudeProductAttributeContract> ProductAttribute { get; set; }

        [DataMember()]
        public List<CrudeProductIdentifierContract> ProductIdentifier { get; set; }

        [DataMember()]
        public List<CrudeProductInfoContract> ProductInfo { get; set; }

        [DataMember()]
        public List<CrudeProductImageContract> ProductImage { get; set; }

        [DataMember()]
        public List<CrudeProductDocumentationContract> ProductDocumentation { get; set; }
    }
}
