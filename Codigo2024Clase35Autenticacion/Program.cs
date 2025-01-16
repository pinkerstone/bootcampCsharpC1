using Codigo2024Clase35Autenticacion.Request;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography.X509Certificates;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAuthentication(options =>
{

}).AddJwtBearer(o =>
{
    o.TokenValidationParameters = new TokenValidationParameters
    {
        ValidIssuer = "https://hugotorrico/",
        ValidAudience = "https://alumnos/",
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("002e538b-7465-415e-9b50-7f2943b165ea-002e538b-7465-415e-9b50-7f2943b165ea")),
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = false,
        ValidateIssuerSigningKey = true
    };
});

var app = builder.Build();

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
    app.UseSwagger();
    app.UseSwaggerUI();
//}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapPost("/securities/Login",
    (UserRequest user) =>
    {
        if (user.Username == "lulloa" && user.Password == "123456")
        {
            //Parametros del token
            var issuer = "https://hugotorrico/"; //emisor
            var Audience = "https://alumnos/"; //receptor
            var key = Encoding.ASCII.GetBytes("002e538b-7465-415e-9b50-7f2943b165ea-002e538b-7465-415e-9b50-7f2943b165ea");

            //Generacion del token
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
                    new Claim("Id", Guid.NewGuid().ToString()),
                    new Claim(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString())
                }),

                Expires = DateTime.UtcNow.AddMinutes(5),
                Issuer = issuer,
                Audience = Audience,
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha512Signature)
            };
            
            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.CreateToken(tokenDescriptor);
            var jwtToken = tokenHandler.WriteToken(token);

            return Results.Ok(jwtToken);

        }

        else
        {
            return Results.Unauthorized();
        }
        
});

app.Run();
