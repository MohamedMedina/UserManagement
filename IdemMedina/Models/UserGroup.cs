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
    
    public partial class UserGroup
    {
        public int Id { get; set; }
        public int userId { get; set; }
        public int groupId { get; set; }
    
        public virtual Group Group { get; set; }
        public virtual User User { get; set; }
    }
}
