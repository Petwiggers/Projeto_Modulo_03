using System.Text.Json;
using System.Text.Json.Serialization;
using M3P_BackEnd_Squad1.DataBase;
using M3P_BackEnd_Squad1.DataBase.Repositories;
using M3P_BackEnd_Squad1.Interfaces.Repositories;
using M3P_BackEnd_Squad1.Middlewares;
using M3P_BackEnd_Squad1.Services;
using M3P_BackEnd_Squad1.Utilities;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

//Adicionando um Middleware de Autenticação JWT 
var jwtChave = builder.Configuration.GetSection("jwtTokenChave").Get<string>();
builder.Services.AddAuthentication(x =>
{
    x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(x =>
{
    x.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(jwtChave)),
        ValidateIssuer = false,
        ValidateAudience = false
    };
});

//Convers�o de Enum para string
builder.Services.AddControllers().AddJsonOptions(x =>
{
    x.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter(JsonNamingPolicy.CamelCase));
});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Repositories

//Context
builder.Services.AddDbContext<LabClothingCollectionDbContext>();
builder.Services.AddScoped<ILoginRepository, LoginRepository>();

//Services
builder.Services.AddScoped<LoginService>();


//Utilities
builder.Services.AddScoped<Cryptography>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//Configurando Api para utilizar Autenticações e Autorizações no Sistema
app.UseAuthentication();
app.UseAuthorization();

//Adicionando Middleware de Erros
app.UseMiddleware<ErrorsMiddleware>();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
