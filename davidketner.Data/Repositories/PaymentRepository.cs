using davidketner.Data.Entities;
using davidketner.Data.Repositories.Interfaces;

namespace davidketner.Data.Repositories
{
    public class PaymentRepository : GenericRepository<Payment, AppDbContext, IServiceContext, int>, IPaymentRepository
    {
        public PaymentRepository(AppDbContext context, IServiceContext serviceContext) : base(context, serviceContext)
        {
        }
    }
}