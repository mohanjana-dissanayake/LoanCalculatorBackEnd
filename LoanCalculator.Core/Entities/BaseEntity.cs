using System.ComponentModel.DataAnnotations;

namespace LoanCalculator.Core.Entities
{
    public class BaseEntity
    {
        [Key]
        public long Id { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime Created { get; set; }
        public DateTime CreatedUtc { get; set; }
        public DateTime? Modified { get; set; }
        public DateTime? ModifiedUtc { get; set; }
        public DateTime? Deleted { get; set; }
        public DateTime? DeletedUtc { get; set; }
    }
}
