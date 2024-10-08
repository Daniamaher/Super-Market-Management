


namespace supermarketsys
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews(); 
            var app = builder.Build();

            app.MapGet("/", () => "Hello World!");
            app.UseRouting();
            /*
            app.MapControllerRoute(

                name: "default",
                pattern: "{controller=Home}/action=Index/{id?}"
                );*/



            app.UseStaticFiles();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
            app.Run();
        }
    }
}
