using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace Quorse.EntityFramework.Repositories
{
    public abstract class QuorseRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<QuorseDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected QuorseRepositoryBase(IDbContextProvider<QuorseDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class QuorseRepositoryBase<TEntity> : QuorseRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected QuorseRepositoryBase(IDbContextProvider<QuorseDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
