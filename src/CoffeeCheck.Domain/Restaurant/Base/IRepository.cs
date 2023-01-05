namespace CoffeeCheck.Domain.Restaurant.Base
{
    public interface IRepository<TEntity> where TEntity : class
    {
        Task<TEntity?> FindFirstByPropertyAsync(string propertyName, object propertyValue);
        Task<TEntity?> AddAsync(TEntity entity);
    }
}
