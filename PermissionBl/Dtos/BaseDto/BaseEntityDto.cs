namespace PermissionBl.Dtos.BaseDto
{
    public interface IBaseEntityDto
    {
        int? Id { get; set; }
        bool Deleted { get; set; }
        DateTimeOffset? CreatedDate { get; set; }
        DateTimeOffset? UpdatedDate { get; set; }
    }

    public class BaseEntityDto : IBaseEntityDto
    {
        public int? Id { get; set; }
        public bool Deleted { get; set; }
        public DateTimeOffset? CreatedDate { get; set; }
        public DateTimeOffset? UpdatedDate { get; set; }
    }
}

