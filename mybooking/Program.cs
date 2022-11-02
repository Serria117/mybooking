using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using mybooking.DataContext;
using mybooking.domain.Entities;
using mybooking.repository;
using mybooking.repository.Contract;
using Swashbuckle.AspNetCore.Filters;

var builder = WebApplication.CreateBuilder(args);
var config = builder.Configuration;
var connectionString = config.GetConnectionString("default");

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

//config swagger for token-based authentication
builder.Services.AddSwaggerGen(op => {
    op.AddSecurityDefinition("oauth2",
        new OpenApiSecurityScheme()
        {
            Description = "Authorization header, using prefix \"bearer {token}\"",
            In          = ParameterLocation.Header,
            Name        = "Authorization",
            Type        = SecuritySchemeType.ApiKey
        });
    op.OperationFilter<SecurityRequirementsOperationFilter>();
});
builder.Services.AddDbContext<AppDbContext>(option => {
    option.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
});

builder.Services.AddIdentity<AppUser, AppRole>()
       .AddEntityFrameworkStores<AppDbContext>();

//Register Jwt Authentication Service:
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(op => {
    op.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(
            Encoding.UTF8.GetBytes(config.GetSection("jwt:key").Value)),
        ValidateIssuer   = false,
        ValidateAudience = false
    };
});

#region Register Dependency Injection

builder.Services.AddScoped(typeof(IBaseRepository<,>), typeof(BaseRepository<,>));

#endregion

var app = builder.Build();

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