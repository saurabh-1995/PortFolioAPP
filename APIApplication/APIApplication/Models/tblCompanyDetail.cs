//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace APIApplication.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblCompanyDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblCompanyDetail()
        {
            this.tblPortfolioDetails = new HashSet<tblPortfolioDetail>();
        }
    
        public string CompanyName { get; set; }
        public string Address { get; set; }
        public string EmailID { get; set; }
        public long PhoneNo { get; set; }
        public string ContactPerson { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblPortfolioDetail> tblPortfolioDetails { get; set; }
    }
}