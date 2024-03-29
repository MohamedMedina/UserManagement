//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IdemMedina.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Request
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Request()
        {
            this.RequestDetails = new HashSet<RequestDetail>();
        }
    
        public int Id { get; set; }
        public string requestNumber { get; set; }
        public Nullable<int> totalQuantity { get; set; }
        public Nullable<System.DateTime> PDD { get; set; }
        public Nullable<int> customerID { get; set; }
        public Nullable<System.DateTime> creationDate { get; set; }
        public Nullable<int> creationUserID { get; set; }
        public Nullable<System.DateTime> approvalDate { get; set; }
        public Nullable<int> approvalUserID { get; set; }
        public Nullable<System.DateTime> receiveDate { get; set; }
        public Nullable<int> receiveUserID { get; set; }
        public Nullable<System.DateTime> rejectionDate { get; set; }
        public Nullable<int> rejectionUserID { get; set; }
        public Nullable<int> rejectionReasonID { get; set; }
        public Nullable<int> requestTypeID { get; set; }
        public Nullable<int> requestStatusID { get; set; }
        public Nullable<int> requestCalssID { get; set; }
        public Nullable<int> requestPriorityID { get; set; }
    
        public virtual RejectReason RejectReason { get; set; }
        public virtual RequestClass RequestClass { get; set; }
        public virtual RequestPriority RequestPriority { get; set; }
        public virtual RequestStatu RequestStatu { get; set; }
        public virtual RequestType RequestType { get; set; }
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
        public virtual User User2 { get; set; }
        public virtual User User3 { get; set; }
        public virtual Customer Customer { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RequestDetail> RequestDetails { get; set; }
    }
}
