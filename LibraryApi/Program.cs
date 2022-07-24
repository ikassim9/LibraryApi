using LibraryApi.Model;
using LibraryApi.Services;
using Microsoft.EntityFrameworkCore;
var builder = WebApplication.CreateBuilder(args);

var allowSpecificOrigns = "allowSpecificOrigins";

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle



builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<LibraryDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));

});

builder.Services.AddScoped<IMemberService, MemberService>();

 


// enable cors (for angular front end)
// 

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: allowSpecificOrigns, builder =>
    {
        builder.WithOrigins("https://localhost:4200").AllowAnyMethod().AllowAnyHeader();
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

app.UseCors(allowSpecificOrigns);

app.UseAuthorization();

app.MapControllers();

app.Run();
