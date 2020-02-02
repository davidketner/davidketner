using davidketner.Data.Entities.Interfaces;
using System.Linq;

namespace davidketner.Data.Repositories.Interfaces
{
    public interface IGenericRepository<TEntity, in TK> where TEntity : IBaseEntity<TK>
    {
        TEntity FindById(TK id);
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(TK id);
        void Delete(TEntity entity);
        IQueryable<TEntity> Items { get; }
    }
}
