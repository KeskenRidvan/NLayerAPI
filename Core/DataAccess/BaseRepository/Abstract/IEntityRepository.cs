﻿using Core.Entities.Abstract;
using System.Linq.Expressions;

namespace Core.DataAccess.BaseRepository.Abstract;

public interface IEntityRepository<TEntity> where TEntity : class, IEntity, new()
{
	List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null);
	TEntity Get(Expression<Func<TEntity, bool>> filter);
	void Add(TEntity entity);
	void Update(TEntity entity);
	void Delete(TEntity entity);
}
