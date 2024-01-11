﻿using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Business;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete;

public class ProductManager : IProductService
{
	private readonly IProductDal _productDal;
	private readonly ICategoryService _categoryService;

	public ProductManager(IProductDal productDal, ICategoryService categoryService)
	{
		_productDal = productDal;
		_categoryService = categoryService;
	}

	[ValidationAspect(typeof(ProductValidator))]
	public IResult Add(Product product)
	{
		IResult result = BusinessRules.Run
		(
			CheckIfProductNameExists(product.ProductName),
			CheckIfProductCountOfCategoryCorrect(product.CategoryId),
			CheckIfCategoryLimitExceded()
		);

		if (result is not null)
			return result;

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


	#region Rules
	private IResult CheckIfProductCountOfCategoryCorrect(int categoryId)
	{
		var result = _productDal.GetAll(p => p.CategoryId.Equals(categoryId)).Count;

		if (result >= 15)
			return new ErrorResult(Messages.ProductCountOfCategoryError);

		return new SuccessResult();
	}

	private IResult CheckIfProductNameExists(string productName)
	{
		var result = _productDal.GetAll(p => p.ProductName.Equals(productName)).Any();

		if (result)
			return new ErrorResult(Messages.ProductNameAlreadyExists);

		return new SuccessResult();
	}

	private IResult CheckIfCategoryLimitExceded()
	{
		var result = _categoryService.GetAll();

		if (result.Data.Count > 15)
			return new ErrorResult(Messages.CategoryLimitExceded);

		return new SuccessResult();
	}

	public IResult AddTransactionalTest(Product product)
	{
		Add(product);
		if (product.UnitPrice < 10)
			throw new Exception("");

		Add(product);

		return null;
	}
	#endregion
}
