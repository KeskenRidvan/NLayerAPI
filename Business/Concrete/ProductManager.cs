using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete;

public class ProductManager : IProductService
{
	private readonly IProductDal _productDal;

	public ProductManager(IProductDal productDal)
	{
		_productDal = productDal;
	}

	public IResult Add(Product product)
	{
		_productDal.Add(product);
		return new SuccessResult(Messages.ProductAdded);
	}

	public IResult Delete(Product product)
	{
		_productDal.Delete(product);
		return new SuccessResult(Messages.ProductDeleted);
	}

	public IDataResult<List<Product>> GetAll()
	{
		return new SuccessDataResult<List<Product>>(_productDal.GetAll().ToList(), Messages.CategoriesListed);
	}

	public IDataResult<Product> GetById(int productId)
	{
		return new SuccessDataResult<Product>(_productDal.Get(p => p.ProductId.Equals(productId)), Messages.ProductListed);
	}

	public IResult Update(Product product)
	{
		_productDal.Update(product);
		return new SuccessResult(Messages.ProductUpdated);
	}

	public List<ProductDetailDto> GetProductDetails()
	{
		return _productDal.GetProductDetails();
	}
}
