using Microsoft.Extensions.DependencyInjection;
using TestConverter.Factories.DataFactories;
using TestConverter.Handlers;
using TestConverter.Repositories;
using TestConverter.Services;

namespace TestConverter
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IPersonHandler, AddressHandler>();
            services.AddScoped<IPersonHandler, AddressFamilyHandler>();
            services.AddScoped<IPersonHandler, PhoneHandler>();
            services.AddScoped<IPersonHandler, PhoneFamilyHandler>();
            services.AddScoped<IPersonHandler, PersonHandler>();
            services.AddScoped<IPersonHandler, FamilyHandler>();
            services.AddScoped<PeopleRepository>();
            services.AddScoped<PeopleService>();
            services.AddScoped<ConvertDataService>();

            services.AddScoped<AddressFactory>();
            services.AddScoped<FamilyAddressFactory>();
            services.AddScoped<FamilyFactory>();
            services.AddScoped<FamilyPhoneFactory>();
            services.AddScoped<PersonFactory>();
            services.AddScoped<PhoneFactory>();
            return services;
        }
    }
}
