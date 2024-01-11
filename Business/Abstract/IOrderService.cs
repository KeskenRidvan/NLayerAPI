using Core.Utilities.Results.Abstract;
using Entities.Concrete;

namespace Business.Abstract;

public interface IOrderService
{
	IDataResult<Order> GetById(int orderId);
	IDataResult<List<Order>> GetAll();
	IResult Add(Order order);
	IResult Update(Order order);
	IResult Delete(Order order);
}
