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
    
    public partial class Employee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employee()
        {
            this.Header_Transaction = new HashSet<Header_Transaction>();
        }
    
        public Nullable<int> id_job { get; set; }
        public int id { get; set; }
        public string password_employee { get; set; }
        public string name_employee { get; set; }
        public string email_employee { get; set; }
        public string address_employee { get; set; }
        public string phone_number_employee { get; set; }
        public Nullable<System.DateTime> date_of_birth_employee { get; set; }
        public Nullable<decimal> salary_employee { get; set; }
    
        public virtual Job Job { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Header_Transaction> Header_Transaction { get; set; }
    }
}
