﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Bot.Builder.BotFramework;
using Microsoft.Bot.Builder.Integration.AspNet.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using parrot;
using parrot.Extensions;

namespace samplebot
{
	public class Startup
	{
		public IConfiguration Configuration { get; }

		public Startup(IHostingEnvironment env)
		{
			Configuration = new ConfigurationBuilder()
				.SetBasePath(env.ContentRootPath)
				.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
				.AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
				.AddEnvironmentVariables()
				.Build();
		}

		public void ConfigureServices(IServiceCollection services)
		{
			services.AddMvc();
			services.AddDbContext<ParrotContext>(options =>
			{
				options.UseSqlite(Configuration.GetConnectionString("DefaultConnection"));
			});
			services.AddParrot();
			services.AddSingleton(_ => Configuration);
			services.AddBot<SampleBot>(options =>
			{
				options.CredentialProvider = new ConfigurationCredentialProvider(Configuration);
			});
		}

		public void Configure(IApplicationBuilder app, IHostingEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}

			app
				.UseMvc()
				.UseDefaultFiles()
				.UseStaticFiles()
				.UseBotFramework();
		}
	}
}
