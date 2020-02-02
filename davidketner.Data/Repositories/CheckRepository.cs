using davidketner.Data.Entities;
using davidketner.Data.Repositories.Interfaces;

namespace davidketner.Data.Repositories
{
    public class CheckRepository : GenericRepository<Check, AppDbContext, IServiceContext, int>, ICheckRepository
    {
        public CheckRepository(AppDbContext context, IServiceContext serviceContext) : base(context, serviceContext)
        {
        }
    }
}