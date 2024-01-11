using Core.DataAccess.BaseRepository.Concrete.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework;

public class EfProductDal : EfEntityRepository<Product, AppDbContext>, IProductDal
{
	public List<ProductDetailDto> GetProductDetails()
	{
		using (AppDbContext context = new AppDbContext())
		{
			var result = from p in context.Products
									 join c in context.Categories
									 on p.CategoryId equals c.CategoryId
									 select new ProductDetailDto { ProductId = p.ProductId, ProductName = p.ProductName, CategoryName = c.CategoryName, UnitsInStock = p.UnitsInStock };
			return result.ToList();
		}
	}
}
