using davidketner.Data.Entities.Interfaces;
using davidketner.Data.Enums;
using System;

namespace davidketner.Data.Entities
{
    public class Payment : BaseEntity<int>, ISoftDeletable
    {
        public string Name { get; set; }
        public string FilePath { get; set; }
        public DateTime? Paid { get; set; }
        public decimal Amount { get; set; }
        public Currency Currency { get; set; }
        public Company Company { get; set; }
    }
}
