using WebApiWithRepositorySample.Entity;
using WebApiWithRepositorySample.Repository.Infrastructure;

namespace WebApiWithRepositorySample.Repository
{
public interface IProductRepository : IGenericRepository<Product>
{
}
}
