using Business.Abstract;
using DataAccess.Abstract;
using Entities.DTOs;

namespace Business.Concrete;

public class ProductManager : IProductService
{
	private IProductDal _productDal;

	public ProductManager(IProductDal productDal)
	{
		_productDal = productDal;
	}

	public List<ProductDetailDto> GetProductDetails()
	{
		return _productDal.GetProductDetails();
	}
}
