using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors.Autofac.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System.Reflection;
using Module = Autofac.Module;

namespace Business.DependencyResolvers.Autofac;

public class AutofacBusinessModule : Module
{
	protected override void Load(ContainerBuilder builder)
	{
		builder.RegisterType<ProductManager>().As<IProductService>();
		builder.RegisterType<EfProductDal>().As<IProductDal>();

		builder.RegisterType<CategoryManager>().As<ICategoryService>();
		builder.RegisterType<EfCategoryDal>().As<ICategoryDal>();

		builder.RegisterType<OrderManager>().As<IOrderService>();
		builder.RegisterType<EfOrderDal>().As<IOrderDal>();

		builder.RegisterType<CustomerManager>().As<ICustomerService>();
		builder.RegisterType<EfCustomerDal>().As<ICustomerDal>();


		var assembly = Assembly.GetExecutingAssembly();
		builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces().EnableInterfaceInterceptors(new ProxyGenerationOptions()
		{
			Selector = new AspectInterceptorSelector()
		}).SingleInstance();
	}
}
