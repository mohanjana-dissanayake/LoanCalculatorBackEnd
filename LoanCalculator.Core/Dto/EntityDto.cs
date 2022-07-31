namespace LoanCalculator.Core.Dto
{
    public class EntityDto : BaseEntityDto
    {
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
