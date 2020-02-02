using davidketner.Data.Repositories.Interfaces;

namespace davidketner.Data
{
    public class AppService
    {
        public IPaymentRepository Payments { get; set; }
        public IDailyRevenueRepository Revenues { get; set; }
    }
}
