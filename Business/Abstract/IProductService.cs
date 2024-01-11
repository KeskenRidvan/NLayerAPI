using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract;

public interface IProductService
{
	IDataResult<Product> GetById(int productId);
	IDataResult<List<Product>> GetAll();
	IResult Add(Product product);
	IResult Update(Product product);
	IResult Delete(Product product);
	List<ProductDetailDto> GetProductDetails();
}
