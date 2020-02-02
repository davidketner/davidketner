using davidketner.Data.Entities;
using davidketner.Data.Repositories.Interfaces;

namespace davidketner.Data.Repositories
{
    public class DailyRevenueRepository : GenericRepository<DailyRevenue, AppDbContext, IServiceContext, int>, IDailyRevenueRepository
    {
        public DailyRevenueRepository(AppDbContext context, IServiceContext serviceContext) : base(context, serviceContext)
        {
        }
    }
}
