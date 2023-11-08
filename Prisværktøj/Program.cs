using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Pricetool;
using Pricetool.Services;
using Pricetool.Services.CustomerServices;
using Prisværktøj.Infrastructure.Repositories;
using Prisværktøj.Infrastructure.Services;
using Radzen;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
//Radzen Services
builder.Services.AddScoped<DialogService>();
builder.Services.AddScoped<NotificationService>();
builder.Services.AddScoped<TooltipService>();
builder.Services.AddScoped<ContextMenuService>();
builder.Services.AddBlazorBootstrap();
builder.Services.AddScoped<Pricetool.Models.DialogServices>();
builder.Services.AddScoped<SearchService>();
builder.Services.AddSingleton<ICustomerService, CustomerService>();
builder.Services.AddHttpClient();






//
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

//Dependency Injection
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<IChildrenRepository, ChildrenRepository>();
builder.Services.AddScoped<IChildrenService, ChildrenService>();
builder.Services.AddScoped<IInfoCardRepository, InfoCardRepository>();
builder.Services.AddScoped<IInfoCardService, InfoCardService>();
builder.Services.AddHttpClient("CorporateApi", client => client.BaseAddress = new Uri("https://localhost:7155/"));
builder.Services.AddScoped< ICorporateService, CorporateService >();




builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.Build().RunAsync();