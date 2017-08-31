namespace FlowersShop.BLL.Infrastructure
{
    using FlowersShop.DAL.Interfaces;
    using FlowersShop.DAL.Repositories;
    using Ninject.Modules;

    public class ServiceModule : NinjectModule
    {
        private string connectionString;

        public ServiceModule(string connection)
        {
            connectionString = connection;
        }

        public override void Load()
        {
            Bind<IUnitOfWork>().To<EFUnitOFWork>().WithConstructorArgument(connectionString);
        }
    }
}
