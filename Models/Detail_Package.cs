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
    
    public partial class Detail_Package
    {
        public Nullable<int> id_service { get; set; }
        public Nullable<int> id_package { get; set; }
        public int id_detail_package { get; set; }
        public Nullable<int> total_unit_detail_package { get; set; }
    
        public virtual Package Package { get; set; }
        public virtual Service Service { get; set; }
    }
}
