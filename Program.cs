using GuidGeneratorWithASP;
using GuidGeneratorWithASP.DI;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IScopeGuid, ScopeGuid>();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapGet("/get", async (HttpContext context, IScopeGuid scopeGuid) =>
{
    await context.Response.WriteAsync(scopeGuid.GetGuid());
});

app.Run();
