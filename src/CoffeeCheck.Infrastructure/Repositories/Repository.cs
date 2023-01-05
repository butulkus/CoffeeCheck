using AutoMapper;
using CoffeeCheck.Domain.Restaurant.Base;
using Microsoft.EntityFrameworkCore;

namespace CoffeeCheck.Infrastructure.Repositories
{
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private protected DbSet<TEntity> DbSet;
        private protected CoffeeCheckContext Context;
        private protected readonly IMapper Mapper;

        public Repository(CoffeeCheckContext context, IMapper mapper)
        {
            DbSet = context.Set<TEntity>();
            Context = context;
            Mapper = mapper;
        }

        public async Task<TEntity?> FindFirstByPropertyAsync(string propertyName, object propertyValue)
        {
            var entity = await DbSet.AsNoTracking()
                .FirstOrDefaultAsync(x => propertyValue.Equals(EF.Property<string>(x, propertyName)));

            return entity;
        }

        public async Task<TEntity?> AddAsync(TEntity entity)
        {
            var result = await DbSet.AddAsync(entity);

            return result.Entity;
        }
    }
}
