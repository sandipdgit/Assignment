var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => Results.Redirect("/Html/index.html"));


app.UseStaticFiles();
app.UseDefaultFiles();

app.Run();
