using EstoqueAPI.Models;

namespace EstoqueAPI.Repositorys
{
    public interface IProductRepository
    {
        Task RegisterProduct(ProductModel product);
    }
}
