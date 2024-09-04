using Garanti.API.Extensions;
using Garanti.API.Middleware;
using Garanti.Application.Commands;
using Garanti.Application.Queries;
using Garanti.Infrastructure;
using Garanti.Infrastructure.EF;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<GarantiContext>();

builder.Services.AddMediatR(opt =>
{
    opt.RegisterServicesFromAssemblyContaining<GetAllCategoriesQuery>();
    opt.RegisterServicesFromAssemblyContaining<GetCategoryByIdQuery>();
    opt.RegisterServicesFromAssemblyContaining<GetAllProductsWithPaginationQuery>();
    opt.RegisterServicesFromAssemblyContaining<CreateCategoryCommand>();
    opt.RegisterServicesFromAssemblyContaining<DeleteCategoryCommand>();
    opt.RegisterServicesFromAssemblyContaining<UpdateCategoryCommand>();
    opt.RegisterServicesFromAssemblyContaining<AdminUserLoginCommand>();
    opt.RegisterServicesFromAssemblyContaining<CreateProductCommand>();
});


builder.Services.AddScoped<IAuthenticationService, AuthenticationService>();

builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

builder.Services.AddRepositories();
builder.Services.AddValidations();

builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(options =>
{
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        ValidIssuer = "Jwt:GarantiBank",
        ValidAudience = "Jwt:GarantiBank",
        ClockSkew = TimeSpan.Zero,
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("loremipsumloremipsumloremipsumloremipsum"))
    };
});

builder.Services.AddAuthorization();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

//app.UseMiddleware<ExceptionMiddleware>();
app.UseAuthorization();

app.MapControllers();

app.Run();
