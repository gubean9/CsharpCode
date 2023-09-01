namespace Empty_core
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            bulider.Services.AddControllersWithViews();
            var app = builder.Build();

            //app.MapGet("/", () => "Hello World!");
            app.UseStaticFiles();
            app.MapControllerRoute{
                name:"default",
                pattern:"{controller=Home}/{action=Index}/{id?}"
            }

            app.Run();
        }
    }
}