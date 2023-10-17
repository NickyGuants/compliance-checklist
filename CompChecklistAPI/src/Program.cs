using Microsoft.EntityFrameworkCore;
using CompChecklistAPI.Models;
using CompChecklistAPI.Interfaces;
using CompChecklistAPI.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddScoped<IComplianceTaskService, ComplianceTaskService>();
//builder.Services.AddDbContext<CompContext>(opt => opt.UseInMemoryDatabase("ComplianceTasks"));
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Add CORS services
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(
        builder =>
        {
            builder.AllowAnyOrigin()
                   .AllowAnyMethod()
                   .AllowAnyHeader();
        });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// Use CORS middleware
app.UseCors();

app.UseAuthorization();

app.MapControllers();

app.Run();
