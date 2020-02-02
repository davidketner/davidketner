using davidketner.Data.Repositories.Interfaces;

namespace davidketner.Data
{
    public interface IAppService
    {
        IPaymentRepository Payments { get; set; }
        IDailyRevenueRepository Revenues { get; set; }
    }
}
