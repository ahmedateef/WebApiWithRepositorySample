using WebApiWithRepositorySample.Model;

namespace WebApiWithRepositorySample.Service
{
public interface IProductService
{
    GetAllProductResponse GetAllProducts();
    void AddProduct(AddProductRequest reqModel);
}
}
