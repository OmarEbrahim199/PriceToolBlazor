using Microsoft.EntityFrameworkCore;
using PricetoolAPI.Application.Services;
using PricetoolAPI.DataAccess;
using PricetoolAPI.DataAccess.Repositories;
using PricetoolAPI.Domain;

var builder = WebApplication.CreateBuilder(args);
var configuration = new ConfigurationBuilder().AddEnvironmentVariables()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json")
    .Build();



// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Services

builder.Services.AddDbContext<DataContext>(options =>
    options.UseSqlServer(configuration.GetConnectionString("PricetoolConnection")));
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddScoped<ICorporateRepository, CorporateRepository>();
builder.Services.AddScoped<ICorporateService, CorporateService>();
builder.Services.AddScoped<ISubsidiaryRepository, SubsidiaryRepository>();
builder.Services.AddScoped<ISubsidiaryService, SubsidiaryService>();
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<IProductService, ProductService>();

builder.Services.AddCors(options =>
{
    options.AddPolicy("all", builder => builder.AllowAnyOrigin()
    .AllowAnyHeader()
    .AllowAnyMethod());
});


var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<DataContext>();
    context.Database.Migrate();
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.UseCors("all");

app.Run();
