﻿using Core.Utilities.IoC.Abstract;
using Core.Utilities.IoC.Concrete;
using Microsoft.Extensions.DependencyInjection;

namespace Core.Extensions;

public static class ServiceCollectionExtensions
{
	public static IServiceCollection AddDependencyResolvers
			(this IServiceCollection serviceCollection, ICoreModule[] modules)
	{
		foreach (var module in modules)
			module.Load(serviceCollection);

		return ServiceTool.Create(serviceCollection);
	}
}
