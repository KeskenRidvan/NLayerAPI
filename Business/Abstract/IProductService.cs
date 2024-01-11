using Entities.DTOs;

namespace Business.Abstract;

public interface IProductService
{
	List<ProductDetailDto> GetProductDetails();
}
