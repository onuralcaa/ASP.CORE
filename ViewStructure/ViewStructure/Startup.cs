using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ViewStructure
{
	public class Startup
	{
		
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddControllersWithViews();//Mvc servisi aktif hale getirildi.  [AYAR-1]
		}

		
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}

			app.UseStaticFiles();//Kök dosyalarý projede tutmak ve kullanmak için.

			app.UseRouting();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapDefaultControllerRoute();//    [AYAR-2]
			});
		}
	}
}
