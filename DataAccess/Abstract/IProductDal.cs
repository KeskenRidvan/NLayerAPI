﻿using Core.DataAccess.BaseRepository.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Abstract;

public interface IProductDal : IEntityRepository<Product>
{
	List<ProductDetailDto> GetProductDetails();
}
