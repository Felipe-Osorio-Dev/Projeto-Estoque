using EstoqueAPI.AppData;
using EstoqueAPI.Models;

namespace EstoqueAPI.Repositorys
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext _dbContext;

        public ProductRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task RegisterProduct(ProductModel product)
        {
            await _dbContext.Produtos.AddAsync(product);
            await _dbContext.SaveChangesAsync();
        }
    }
}
