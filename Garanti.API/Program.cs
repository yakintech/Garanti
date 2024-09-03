using Garanti.Application.Commands;
using Garanti.Application.Queries;
using Garanti.Infrastructure;
using Garanti.Infrastructure.EF;
using Garanti.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<GarantiContext>();

builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<IOrderRepository, OrderRepository>();
builder.Services.AddScoped<IOrderDetailRepository, OrderDetailRepository>();



builder.Services.AddMediatR(opt =>
{
    opt.RegisterServicesFromAssemblyContaining<GetAllCategoriesQuery>();
    opt.RegisterServicesFromAssemblyContaining<GetCategoryByIdQuery>();
    opt.RegisterServicesFromAssemblyContaining<GetAllProductsWithPaginationQuery>();
    opt.RegisterServicesFromAssemblyContaining<CreateCategoryCommand>();
    opt.RegisterServicesFromAssemblyContaining<DeleteCategoryCommand>();
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
