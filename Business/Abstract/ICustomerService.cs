﻿using Core.Utilities.Results.Abstract;
using Entities.Concrete;

namespace Business.Abstract;

public interface ICustomerService
{
	IDataResult<Customer> GetById(int customerId);
	IDataResult<List<Customer>> GetAll();
	IResult Add(Customer customer);
	IResult Update(Customer customer);
	IResult Delete(Customer customer);
}
