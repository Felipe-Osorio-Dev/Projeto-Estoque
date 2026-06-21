using EstoqueAPI.DTO;

namespace EstoqueAPI.Services
{
    public interface IProductService
    {
        Task RegisterProduct(ProductDTO product);
    }
}
