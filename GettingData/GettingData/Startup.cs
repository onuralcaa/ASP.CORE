using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GettingData
{
	public class Startup
	{
		
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddControllersWithViews();//MVC servisi projeye dahil edildi.
		}

		
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}

			app.UseRouting();

			app.UseEndpoints(endpoints =>
			{
				//endpoints.MapDefaultControllerRoute();//varsayýlan conroller ayarlarý yüklendi.

				//rota oluþturma
				endpoints.MapControllerRoute("CustomRoute", "{Controller=home}/{Action=index}/{id?}/{ProductName?}/{CategoryName?}");


			});
		}
	}
}
