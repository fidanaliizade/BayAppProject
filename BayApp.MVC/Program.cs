using BayApp.Business.Profiles;
using BayApp.Business.Services.Implementations;
using BayApp.Business.Services.Interfaces;
using BayApp.DAL.Context;
using BayApp.DAL.Repositories.Implementations;
using BayApp.DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

		//builder.Services.AddAutoMapper(typeof(FeaturedMapper).Assembly);


		// Add services to the container.
		builder.Services.AddControllersWithViews();
        builder.Services.AddDbContext<AppDbContext>(opt =>
        {
            opt.UseSqlServer(builder.Configuration.GetConnectionString("Default"));
        });

        builder.Services.AddScoped<IFeaturedRepository, FeaturedRepository>();
        builder.Services.AddScoped<IFeaturedServices, FeaturedServices>();

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
           pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}");

        app.Run();
    }
}