using davidketner.Data.Entities.Interfaces;
using davidketner.Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace davidketner.Data.Repositories
{
    public class GenericRepository<TEntity, TC, TSC, TK> : IGenericRepository<TEntity, TK>
    where TC : DbContext where TSC : IServiceContext where TEntity : class, IBaseEntity<TK>
    {
        private readonly TC context;
        public readonly TSC serviceContext;

        public GenericRepository(TC context, TSC serviceContext)
        {
            this.context = context;
            this.serviceContext = serviceContext;
        }

        public virtual IQueryable<TEntity> Items => context.Set<TEntity>().AsNoTracking();

        public TEntity FindById(TK id)
        {
            return context.Set<TEntity>().Find(id);
        }

        public void Add(TEntity entity)
        {
            entity.UserCreatedId = serviceContext.UserId;
            context.Set<TEntity>().Add(entity);
        }

        public void Update(TEntity entity)
        {
            if (!entity.Locked || !string.IsNullOrEmpty(serviceContext.UserId))
            {
                entity.UserUpdatedId = serviceContext.UserId;
                context.Set<TEntity>().Update(entity);
            }
        }

        public virtual void Delete(TK id)
        {
            var entity = FindById(id);
            entity.UserDeletedId = serviceContext.UserId;
            context.Set<TEntity>().Remove(entity);
        }

        public virtual void Delete(TEntity entity)
        {
            entity.UserDeletedId = serviceContext.UserId;
            context.Set<TEntity>().Remove(entity);
        }
    }
}
