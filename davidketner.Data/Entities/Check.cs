using davidketner.Data.Entities.Interfaces;

namespace davidketner.Data.Entities
{
    public class Check : BaseEntity<int>, ISoftDeletable
    {
        public string ErrorMessage { get; set; }
        public bool IsSuccess => string.IsNullOrEmpty(ErrorMessage);
    }
}
