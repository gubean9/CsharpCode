var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//app 초기화 후 설정
app.UseRouting();

//app.MapGet("/Hi", () => "Home Page");
//app.MapGet("/Home", () => "Hello World \n ==GET==");
//app.MapPost("/Home", () => "Hello World \n ==POST==");
//app.MapPut("/Home", () => "Hello World \n ==PUT==");
//app.MapDelete("/Home", () => "Hello World \n ==Delete==");

//메인페이지 만들기
//app.Run(async(HttpContext context) =>
//{
//    //한글 깨짐 방지
//    context.Response.ContentType = "text/plain; charset=utf-8";
//    //"Main Index 페이지입니다."
//    await context.Response.WriteAsync("Main Index 페이지입니다.");
//});

app.UseEndpoints(endpoints =>
{
    endpoints.MapGet("/Home", async (context) =>
    {
        context.Response.ContentType = "text/plain; charset=utf-8";
        await context.Response.WriteAsync("홈페이지입니다.");
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
