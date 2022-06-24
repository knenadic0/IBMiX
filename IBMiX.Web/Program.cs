using Autofac;
using Autofac.Extensions.DependencyInjection;
using AutoMapper;
using AutoMapper.Contrib.Autofac.DependencyInjection;
using IBMiX.Model;
using IBMiX.Repository;
using IBMiX.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//Automapper
//var mapperConfig = new MapperConfiguration(mc => {
//    mc.AddProfile(new ModelsProfile());
//});
//IMapper mapper = mapperConfig.CreateMapper();
var containerBuilder = new ContainerBuilder();
containerBuilder.RegisterAutoMapper(typeof(ModelsProfile).Assembly);
var container = containerBuilder.Build();
var mapper = container.Resolve<IMapper>();
builder.Services.AddSingleton(mapper);

//Autofac
builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
builder.Host.ConfigureContainer<ContainerBuilder>(builder => {
    builder.RegisterModule(new ModelsDIModule());
    builder.RegisterModule(new RepositoryDIModule());
    builder.RegisterModule(new ServiceDIModule());
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
