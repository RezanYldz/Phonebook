using Microsoft.Extensions.DependencyInjection;
using Phonebook.Business.Concrete;
using Phonebook.Business.Interfaces;
using Phonebook.DAL.Concrete.EntityFrameworkCore.Repositories;
using Phonebook.DAL.Interfaces;

namespace Phonebook.Business.Containers.MicrosoftIoC
{
    public static class CustomIoCExtension
    {
        public static void AddDependencies(this IServiceCollection services)
        {
            services.AddScoped(typeof(IGenericDal<>), typeof(EfGenericRepository<>));
            services.AddScoped(typeof(IGenericService<>), typeof(GenericManager<>));
        }
    }
}
