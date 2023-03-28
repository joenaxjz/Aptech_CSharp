using DemoSession2_MVC.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddSession();

builder.Services.AddScoped<DemoSerVice, DemoServiceImp>();

builder.Services.AddScoped<CaculateService, CaculateServiceImp>();

builder.Services.AddScoped<RectangleService, RegactangleServiceImp>();

builder.Services.AddScoped<ProductService, ProductServiceImp>();


builder.Services.AddScoped<AccountService, AccountServiceImp>();    

var app = builder.Build();

//app.MapGet("/", () => "Hello World!"); => mặc định ( ko tính tiền )

app.UseStaticFiles();
app.UseSession();

app.MapControllerRoute(
    name: "default",
    // gõ tên controller mà muốn mặc định chạy vào sau controller= và view mặc định sau action=
    pattern: "{controller}/{action}");

app.Run();