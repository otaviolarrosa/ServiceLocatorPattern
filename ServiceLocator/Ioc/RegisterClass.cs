using Microsoft.Extensions.DependencyInjection;
using ServiceLocator.Business;

namespace ServiceLocator.Ioc
{
    public class RegisterClass
    {
        public void Register(IServiceCollection services)
        {
            services.AddTransient<IMyService, MyService>();
        }
    }
}