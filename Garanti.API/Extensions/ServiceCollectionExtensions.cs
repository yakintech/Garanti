using FluentValidation;
using FluentValidation.AspNetCore;
using Garanti.Application.Validators;
using Garanti.Dto;
using Garanti.Infrastructure.Repositories;

namespace Garanti.API.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<IOrderDetailRepository, OrderDetailRepository>();
            services.AddScoped<IAdminUserRepository, AdminUserRepository>();
            services.AddScoped<IInvoiceRepository, InvoiceRepository>();

            return services;
        }


        public static IServiceCollection AddValidations(this IServiceCollection services)
        {
            services.AddFluentValidationAutoValidation();
            services.AddScoped<IValidator<CreateProductRequestDto>, CreateProductValidator>();

            return services;
        }


    }
}
