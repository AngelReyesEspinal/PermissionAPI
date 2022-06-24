using System;
using PermissionModels.Entities.Base;

namespace PermissionModels.Entities
{
    public class Permission : BaseEntity
    {
        public string EmployeeFirstName { get; set; }
        public string EmployeeLastName { get; set; }
        public DateTime PermissionDate { get; set; }
        public int PermissionTypeId { get; set; }
        public virtual PermissionType? PermissionType { get; set; }
    }
}

