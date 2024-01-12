﻿using Core.CrossCuttingConcerns.Caching;
using Core.CrossCuttingConcerns.Caching.Microsoft;
using Core.Utilities.IoC.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace Core.DependencyResolvers;

public class CoreModule : ICoreModule
{
	public void Load(IServiceCollection serviceCollection)
	{
		serviceCollection.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

		serviceCollection.AddMemoryCache();
		serviceCollection.AddSingleton<ICacheManager, MemoryCacheManager>();
	}
}