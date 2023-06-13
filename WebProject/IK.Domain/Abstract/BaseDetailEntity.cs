namespace IK.Domain.Abstract
{
    public abstract class BaseDetailEntity : BaseEntity
    {
        public DateTime UpdatedAt { get; set; }
        public int UpdatedUserId { get; set; }
        public DateTime DeletedAt { get; set; }
        public int DeletedUserId { get; set; }
    }
}
