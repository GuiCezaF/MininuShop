using Microsoft.EntityFrameworkCore;
using MininuShop.Domain;
using MininuShop.Domain.Entities;
using MininuShop.Infra.Data.Context;

namespace MininuShop.Infra.Data;

public class ProductRepository : IProductRepository
{
  private readonly ApplicationDbContext _db;
  public async Task<Product> CreateAsync(Product product)
  {
    _db.Add(product);
    await _db.SaveChangesAsync();
    return product;
  }

  public async Task DeleteAsync(Product product)
  {
    _db.Remove(product);
    await _db.SaveChangesAsync();
  }

  public async Task EditAsync(Product product)
  {
    _db.Update(product);
    await _db.SaveChangesAsync();
  }

  public async Task<Product> GetByIdAsync(int id)
  {
    return await _db.Products.FirstOrDefaultAsync(x => x.Id == id);
  }

  public async Task<ICollection<Product>> GetProductsAsync()
  {
    return await _db.Products.ToListAsync();
  }
}
