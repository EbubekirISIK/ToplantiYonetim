using Microsoft.Extensions.FileSystemGlobbing.Internal.Patterns;

namespace MeetingApp
{
	public class Program
	{
		public static void Main(string[] args)
		{

			var builder = WebApplication.CreateBuilder(args);
			builder.Services.AddControllersWithViews(); //mvc �ablonu olu�turur.
			var app = builder.Build();
			app.UseStaticFiles(); // bu www.root klos�r�ne direk ula�mak i�in.
			app.UseRouting();

			//app.MapGet("/", () => "Hello World!");
			// app.MapGet("/abc", () => "Hello abc"); burda yeni link ekleyebiliyoruz.

			// yukar�da ki �emay� sildik ve a��a��da ki �emaya uygun yazd�k.

			// controller/action/id? 
			//app.MapDefaultControllerRoute(); bu k�sa yolu altttaki uzun yolu.

			app.MapControllerRoute(
				name: "default",
				pattern: "{controller=Home}/{action=Index}/{id?}"
				);

			app.Run();
		}
	}
}
