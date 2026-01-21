using System.Text.Json;
using PortfolioApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// CORS
const string CorsPolicy = "Frontend";
builder.Services.AddCors(o =>
{
    o.AddPolicy(CorsPolicy, p =>
        p.WithOrigins("http://localhost:5173")
            .AllowAnyHeader()
            .AllowAnyMethod());
});
builder.Services.AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;
    });
builder.Services.Configure<EmailSettings>(
    builder.Configuration.GetSection("EmailSettings")
);

var app = builder.Build();
app.UseStaticFiles();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors(CorsPolicy); // ✅ correct position

app.UseAuthorization();
app.MapControllers();
app.Run();