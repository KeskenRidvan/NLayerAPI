﻿using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete;

public class CategoryManager : ICategoryService
{
	private readonly ICategoryDal _categoryDal;

	public CategoryManager(ICategoryDal categoryDal)
	{
		_categoryDal = categoryDal;
	}

	public IResult Add(Category category)
	{
		_categoryDal.Add(category);
		return new SuccessResult(Messages.CategoryAdded);
	}

	public IResult Delete(Category category)
	{
		_categoryDal.Delete(category);
		return new SuccessResult(Messages.CategoryDeleted);
	}

	public IDataResult<List<Category>> GetAll()
	{
		return new SuccessDataResult<List<Category>>(_categoryDal.GetAll().ToList(), Messages.CategoriesListed);
	}

	public IDataResult<Category> GetById(int categoryId)
	{
		return new SuccessDataResult<Category>(_categoryDal.Get(p => p.CategoryId.Equals(categoryId)), Messages.CategoryListed);
	}

	public IResult Update(Category category)
	{
		_categoryDal.Update(category);
		return new SuccessResult(Messages.CategoryUpdated);
	}
}
