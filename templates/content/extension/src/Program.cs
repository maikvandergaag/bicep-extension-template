using Microsoft.AspNetCore.Builder;
using Bicep.Local.Extension.Host.Extensions;
using Microsoft.Extensions.DependencyInjection;
using Bicep.Extension.Handler;

var builder = WebApplication.CreateBuilder();

builder.AddBicepExtensionHost(args);
builder.Services
    .AddBicepExtension(
        name: "Bicep.Extension",
        version: "1.0.0",
        isSingleton: true,
        typeAssembly: typeof(Program).Assembly)
    .WithResourceHandler<ExampleHandler>();

var app = builder.Build();

app.MapBicepExtension();

await app.RunAsync();