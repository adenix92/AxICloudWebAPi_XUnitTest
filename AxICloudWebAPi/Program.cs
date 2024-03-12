using AxICloudWebAPi.Data;
using AxICloudWebAPi.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

//configuration
builder.Services.AddDbContext<ApplicationDbContextsIdentuty>(option => {
    option.UseSqlServer(builder.Configuration.GetConnectionString("appconnections"));
});

builder.Services.AddIdentity<AppUser, IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContextsIdentuty>();


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();


if (args.Length == 1 && args[0].ToLower() == "seeddata_ap")
{
    using (var scope = app.Services.CreateScope())
    {
    var _service = scope.ServiceProvider;
        Seedapi.seeddata_api(_service);

    }
}



// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
