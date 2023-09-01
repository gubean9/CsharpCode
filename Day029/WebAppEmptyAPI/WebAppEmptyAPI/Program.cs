var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//app �ʱ�ȭ �� ����
app.UseRouting();

//app.MapGet("/Hi", () => "Home Page");
//app.MapGet("/Home", () => "Hello World \n ==GET==");
//app.MapPost("/Home", () => "Hello World \n ==POST==");
//app.MapPut("/Home", () => "Hello World \n ==PUT==");
//app.MapDelete("/Home", () => "Hello World \n ==Delete==");

//���������� �����
//app.Run(async(HttpContext context) =>
//{
//    //�ѱ� ���� ����
//    context.Response.ContentType = "text/plain; charset=utf-8";
//    //"Main Index �������Դϴ�."
//    await context.Response.WriteAsync("Main Index �������Դϴ�.");
//});

app.UseEndpoints(endpoints =>
{
    endpoints.MapGet("/Home", async (context) =>
    {
        context.Response.ContentType = "text/plain; charset=utf-8";
        await context.Response.WriteAsync("Ȩ�������Դϴ�.");
    });
    endpoints.MapPost("/Home", async (context) =>
    {
        //context.Response.ContentType = "text/plain; charset=utf-8";
        await context.Response.WriteAsync("POST");
    });
    endpoints.MapPut("/Home", async (context) =>
    {
        //context.Response.ContentType = "text/plain; charset=utf-8";
        await context.Response.WriteAsync("PUT");
    });
    endpoints.MapDelete("/Home", async (context) =>
    {
        //context.Response.ContentType = "text/plain; charset=utf-8";
        await context.Response.WriteAsync("DELECT");
    });
});

app.Run();
