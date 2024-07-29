using WebApiWithRepositorySample.Entity;
using WebApiWithRepositorySample.Repository.Infrastructure;

namespace WebApiWithRepositorySample.Repository
{
public class ProductRepository : GenericRepository<Product>, IProductRepository
{
    public ProductRepository(ProductDbContext dbContext) : base(dbContext)
    {
    }
}
}
