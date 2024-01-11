using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete;

public class OrderManager : IOrderService
{
	private readonly IOrderDal _orderDal;

	public OrderManager(IOrderDal orderDal)
	{
		_orderDal = orderDal;
	}

	public IResult Add(Order order)
	{
		_orderDal.Add(order);
		return new SuccessResult(Messages.OrderAdded);
	}

	public IResult Delete(Order order)
	{
		_orderDal.Delete(order);
		return new SuccessResult(Messages.OrderDeleted);
	}

	public IDataResult<List<Order>> GetAll()
	{
		return new SuccessDataResult<List<Order>>(_orderDal.GetAll().ToList(), Messages.CategoriesListed);
	}

	public IDataResult<Order> GetById(int orderId)
	{
		return new SuccessDataResult<Order>(_orderDal.Get(p => p.OrderId.Equals(orderId)), Messages.OrderListed);
	}

	public IResult Update(Order order)
	{
		_orderDal.Update(order);
		return new SuccessResult(Messages.OrderUpdated);
	}
}
