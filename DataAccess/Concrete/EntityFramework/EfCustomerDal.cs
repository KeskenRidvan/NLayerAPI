﻿using Core.DataAccess.BaseRepository.Concrete.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework;

public class EfCustomerDal : EfEntityRepository<Customer, AppDbContext>, ICustomerDal
{
}
