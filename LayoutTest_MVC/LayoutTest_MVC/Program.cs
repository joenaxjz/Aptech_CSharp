var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var app = builder.Build();

//app.MapGet("/", () => "Hello World!"); => mặc định ( ko tính tiền )

app.UseStaticFiles();
app.MapControllerRoute(
    name: "default",
    // gõ tên controller mà muốn mặc định chạy vào sau controller= và view mặc định sau action=
    pattern: "{controller}/{action}");

app.Run();
