using System;
namespace PermissionModels.Entities.Base
{
    public interface IBaseEntity
    {
        int Id { get; set; }
        bool Deleted { get; set; }
        DateTimeOffset? CreatedDate { get; set; }
        DateTimeOffset? UpdatedDate { get; set; }
    }

    public class BaseEntity : IBaseEntity
    {
        public virtual int Id { get; set; }
        public virtual bool Deleted { get; set; }
        public virtual DateTimeOffset? CreatedDate { get; set; }
        public virtual DateTimeOffset? UpdatedDate { get; set; }
    }
}

