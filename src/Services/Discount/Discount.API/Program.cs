using Discount.API.Extensions;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace Discaount.API
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var host = CreateHostBuilder(args)
				.Build();

			host.MigrateDatabase<Program>(retry: 4)
				.Run();
		}

		public static IHostBuilder CreateHostBuilder(string[] args) =>
			Host.CreateDefaultBuilder(args)
				.ConfigureWebHostDefaults(webBuilder =>
				{
					webBuilder.UseStartup<Startup>();
				});
	}
}
