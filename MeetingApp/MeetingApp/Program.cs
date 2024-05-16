using Microsoft.Extensions.FileSystemGlobbing.Internal.Patterns;

namespace MeetingApp
{
	public class Program
	{
		public static void Main(string[] args)
		{

			var builder = WebApplication.CreateBuilder(args);
			builder.Services.AddControllersWithViews(); //mvc þablonu oluþturur.
			var app = builder.Build();
			app.UseStaticFiles(); // bu www.root klosörüne direk ulaþmak için.
			app.UseRouting();

			//app.MapGet("/", () => "Hello World!");
			// app.MapGet("/abc", () => "Hello abc"); burda yeni link ekleyebiliyoruz.

			// yukarýda ki þemayý sildik ve aþþaðýda ki þemaya uygun yazdýk.

			// controller/action/id? 
			//app.MapDefaultControllerRoute(); bu kýsa yolu altttaki uzun yolu.

			app.MapControllerRoute(
				name: "default",
				pattern: "{controller=Home}/{action=Index}/{id?}"
				);

			app.Run();
		}
	}
}
