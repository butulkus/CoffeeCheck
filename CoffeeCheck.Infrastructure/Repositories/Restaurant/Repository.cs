using CoffeeCheck.Domain.Restaurant.Base;
using Microsoft.EntityFrameworkCore;

namespace CoffeeCheck.Infrastructure.Repositories.Restaurant
{
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private protected DbSet<TEntity> DbSet;
        private protected CoffeeCheckContext Context;

        public Repository(DbSet<TEntity> dbSet, CoffeeCheckContext context)
        {
            DbSet = dbSet;
            Context = context;
        }
    }
}
