using layered_Architecture.BusinessLayer.Abstract;
using layered_Architecture.BusinessLayer.Concrete;
using layered_Architecture.Core;
using layered_Architecture.DataAccess.Abstract;
using layered_Architecture.DataAccess.Concrete.Context;
using layered_Architecture.DataAccess.EntityFramework;
using layered_Architecture.DataAccess.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Configuration;

var builder = WebApplication.CreateBuilder(args);
builder.Services.Configure<AppSetting>(builder.Configuration.GetSection("AppSetting"));
builder.Services.AddCors();
builder.Services.AddDbContext<Context>(option =>
{
    var provider = builder.Services.BuildServiceProvider();
    var config = provider.GetService<IOptions<AppSetting>>();
    option.UseSqlServer(config.Value.ConnectionString);
    option.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
});
builder.Services.AddScoped(typeof(IGenericDal<>), typeof(GenericRepository<>));
builder.Services.AddScoped<IAbout_Service, About_Manager>();
builder.Services.AddScoped<IBlog_Service, Blog_Manager>();
builder.Services.AddScoped<IComment_Service, Comment_Manager>();
builder.Services.AddScoped<ICategory_Service, Category_Manager>();
builder.Services.AddScoped<IContact_Service, Contact_Manager>();
builder.Services.AddScoped<IWriter_Service, Writer_Manager>();
builder.Services.AddScoped<IwritersCountry_City_Service, writersCountry_City_Manager>();


builder.Services.AddScoped<IAboutDal, EfAboutRepository>();
builder.Services.AddScoped<IBlogDal, EfBlogRepository>();
builder.Services.AddScoped<ICommentDal, EfCommentRepository>();
builder.Services.AddScoped<ICategoryDal, EfCategoryRepository>();
builder.Services.AddScoped<IContactDal, EfContactRepository>();
builder.Services.AddScoped<IWriterDal, EfWriterRepository>();
builder.Services.AddScoped<IwritersCountry_CityDal, EfwritersCountry_CityRepository>();
builder.Services.AddControllers();



builder.Services.AddRazorPages();



var app = builder.Build();

// Add services to the container.
builder.Services.AddControllersWithViews();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

//app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
