//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FSBT_HHT_DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserGroup
    {
        public UserGroup()
        {
            this.ConfigUserGroups = new HashSet<ConfigUserGroup>();
            this.ConfigUserGroupReports = new HashSet<ConfigUserGroupReport>();
            this.ConfigUserGroupScreens = new HashSet<ConfigUserGroupScreen>();
        }
    
        public string GroupID { get; set; }
        public string GroupName { get; set; }
        public System.DateTime CreateDate { get; set; }
        public string CreateBy { get; set; }
        public System.DateTime UpdateDate { get; set; }
        public string UpdateBy { get; set; }
    
        public virtual ICollection<ConfigUserGroup> ConfigUserGroups { get; set; }
        public virtual ICollection<ConfigUserGroupReport> ConfigUserGroupReports { get; set; }
        public virtual ICollection<ConfigUserGroupScreen> ConfigUserGroupScreens { get; set; }
    }
}
