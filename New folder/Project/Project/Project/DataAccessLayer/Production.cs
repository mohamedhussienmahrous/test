//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Project.DataAccessLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class Production
    {
        public Production()
        {
            this.ProductionMaterials = new HashSet<ProductionMaterial>();
        }
    
        public int ProductionId { get; set; }
        public int FK_ProductId { get; set; }
        public System.DateTime ProductionDate { get; set; }
        public int Quantity { get; set; }
    
        public virtual ICollection<ProductionMaterial> ProductionMaterials { get; set; }
        public virtual Product Product { get; set; }
    }
}