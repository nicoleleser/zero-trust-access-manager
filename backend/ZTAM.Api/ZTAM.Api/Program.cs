using Microsoft.EntityFrameworkCore;
using ZTAM.Api;
using ZTAM.Api.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Add DbContext
builder.Services.AddDbContext<ZTAMContext>(options =>
    options.UseSqlite("Data Source=ZTAM.db"));

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

var scope = app.Services.CreateScope();
var db = scope.ServiceProvider.GetRequiredService<ZTAMContext>();
SeedData.Initialize(db);

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
