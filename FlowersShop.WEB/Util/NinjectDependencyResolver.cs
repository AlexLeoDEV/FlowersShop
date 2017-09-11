using FlowersShop.BLL.Interfaces;
using FlowersShop.BLL.Services;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FlowersShop.WEB.Util
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private IKernel kernel;
        public NinjectDependencyResolver(IKernel kernelParam)
        {
            kernel = kernelParam;
            AddBindings();
        }
        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }
        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }
        private void AddBindings()
        {
            kernel.Bind<ICommoditiesService>().To<CommoditiesService>();
            kernel.Bind<ICategoryService>().To<CategoryService>();
            kernel.Bind<IClientService>().To<ClientService>();
            kernel.Bind<IOrderService>().To<OrderService>();
            kernel.Bind<ICityService>().To<CityService>();
            kernel.Bind<ICommoditiesByCategory>().To<CommoditiesByCategoryService>();
        }
    }
}