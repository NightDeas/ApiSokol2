using Microsoft.EntityFrameworkCore;
using WebApi;
using WebApi.Repositories;
using WebApi.Repositories.Interfaces;
using WebApi.Services;

var builder = WebApplication.CreateBuilder(args);

ConfigureDatabase(builder);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<Context>();

builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<ProductRepository>();
builder.Services.AddScoped<ProductService>();

builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<UserRepository>();
builder.Services.AddScoped<UserService>();

builder.Services.AddScoped<IOrderRepository, OrderRepository>();
builder.Services.AddScoped<OrderRepository>();
builder.Services.AddScoped<OrderService>();

builder.Services.AddScoped<ITypeProductRepository, TypeProductRepository>();
builder.Services.AddScoped<TypeProductRepository>();
builder.Services.AddScoped<TypeProductService>();

builder.Services.AddScoped<INewsRepository, NewsRepository>();
builder.Services.AddScoped<NewsRepository>();
builder.Services.AddScoped<NewsService>();






var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseSwagger();
app.UseSwaggerUI();


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();


app.Run();

static void ConfigureDatabase(WebApplicationBuilder builder)
{
    var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Database connection string is not configured.");
    builder.Services.AddDbContext<Context>(options =>
        options.UseNpgsql(connectionString, b => b.MigrationsAssembly(typeof(Program).Assembly.FullName)));
    builder.Services.AddHostedService<MigrationHostedService>();
}