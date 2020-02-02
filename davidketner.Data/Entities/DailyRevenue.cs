using davidketner.Data.Entities.Interfaces;
using davidketner.Data.Enums;
using System;

namespace davidketner.Data.Entities
{
    public class DailyRevenue : BaseEntity<int>, ISoftDeletable
    {
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public int Registrations { get; set; }
        public Currency Currency { get; set; }
        public Company Company { get; set; }
    }
}
