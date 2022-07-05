using PermissionBl.Dtos.BaseDto;

namespace PermissionBl.Dtos
{
	public class PermissionDto : BaseEntityDto
    {
        public string EmployeeFirstName { get; set; }
        public string EmployeeLastName { get; set; }
        public DateTime? PermissionDate { get; set; }
        public int? PermissionTypeId { get; set; }
        public string PermissionTypeDescription { get; set; }
    }
}

