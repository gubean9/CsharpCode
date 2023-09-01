namespace WebAppControler
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews(); //MVC��������... �� ���? �������� �Ⱥ���
            var app = builder.Build();


            //app.MapGet("/", () => "Hello World!");
            //app.MapDefaultControllerRoute();
            /*
            app.MapControllerRoute(
                name:"default",
                //pattern:"{controller=Home}/{action=Index}/{id?}"
                //pattern: "{controller=First}/{action=First}/{id?}"
                //pattern: "{controller=First}/{action=About}/{id?}"
                pattern: "{controller=Home}/{action=About}/{id?}"
            );
            */  

            app.MapControllerRoute(
                name:"default",
                pattern:"{controller=Home}/{action=Index}/{id?}"
            );

            app.Run();
        }
    }
}