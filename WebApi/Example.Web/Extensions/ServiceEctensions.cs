using System;
using Microsoft.EntityFrameworkCore;
using Repositories;
using Repositories.Contracts;
using Repositories.EFCore;
using Services;
using Services.Contracts;
namespace Example.Web.Extensions
{
	public static class ServiceEctensions
	{
		public static void ConfigureSQLContext(this IServiceCollection services,IConfiguration configuration)//benim servisim configration dan alsın
		{
			services.AddDbContext<RepositoryContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
		}
		public static void ConfigerRepositoryMananger(this IServiceCollection services)
		{
			services.AddScoped<IRepositoryMananger,RepositoryMananger>(); //isteğim için bana respons ver
		}
		public static void ConfigureServiceMananger(this IServiceCollection services)
		{
			services.AddScoped<IServiceMananger, ServiceMananger>();
		}
	}
}

