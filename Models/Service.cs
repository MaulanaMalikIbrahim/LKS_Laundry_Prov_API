//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LKS_Laundry_Prov_API.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Service
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Service()
        {
            this.Detail_Package = new HashSet<Detail_Package>();
            this.Detail_Transaction = new HashSet<Detail_Transaction>();
        }
    
        public Nullable<int> id_category { get; set; }
        public Nullable<int> id_unit { get; set; }
        public int id_service { get; set; }
        public string name_service { get; set; }
        public Nullable<int> price_unit_service { get; set; }
        public Nullable<int> estimation_duration_service { get; set; }
    
        public virtual Category Category { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Detail_Package> Detail_Package { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Detail_Transaction> Detail_Transaction { get; set; }
        public virtual Unit Unit { get; set; }
    }
}
