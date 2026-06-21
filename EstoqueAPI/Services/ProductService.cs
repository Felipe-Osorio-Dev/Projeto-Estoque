using EstoqueAPI.DTO;
using EstoqueAPI.Models;
using EstoqueAPI.Repositorys;
using MapsterMapper;

namespace EstoqueAPI.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repository;
        private readonly IMapper _mapper;

        public ProductService(IProductRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task RegisterProduct(ProductDTO product)
        {
            var newProduct = _mapper.Map<ProductModel>(product);
            await _repository.RegisterProduct(newProduct);
        }
    }
}
