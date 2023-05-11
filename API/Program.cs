using Default.Utils.Exceptions;
using Default.Utils.Extensions;
using Default.Utils.Mappings;
using MetaTraderDream.Api.Configurations;
using MetaTraderDream.Api.Core.BackgroundServices;
using Microsoft.Net.Http.Headers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddResponseCaching();
builder.Services.AddHttpContextAccessor();
builder.Services.AddMapster();
builder.Services.SetupMediatR();
builder.Services.AddAntiforgery();
builder.Services.AddMvc(options => options.Filters.Add(new WebExceptionFilter()));

builder.Services.CreateSwagger();
builder.Services.CreateRateLimiting(builder.Configuration);

builder.Services.AddHostedService<SignalReceiver>();


var app = builder.Build();

app.UseCors();
app.UseRouting();



builder.InitDatabases();

AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

app.UseResponseCaching();
app.Use(async (context, next) =>
{
    context.Response.GetTypedHeaders().CacheControl =
        new CacheControlHeaderValue()
        {
            Public = true,
            MaxAge = TimeSpan.FromMinutes(60)
        };
    context.Response.Headers[HeaderNames.Vary] =
        new string[] { "Accept-Encoding" };

    await next();
});
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();
app.UseAuthentication();

app.MapControllers();

app.Run();
