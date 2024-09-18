//dotnet new api para criar
//dotnet watch run, watch = fica observando os arquivos da api e caso identifique uma mudança vai recompilar o projeto
//dotnet tool install --global dotnet-ef = instala ferramenta para executar comando do entity framework via terminal
//dotnet add package Microsoft.EntityFrameworkCore.Design = precisa instalar em todo projeto, instala o pacote entity framework
//dotnet add package Microsoft.EntityFrameworkCore.SqlServer = também precisa em todo projeto

using ModuloAPI.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//agenda context usa sqlserver, builder.configuration pega a configuração do appsettings
builder.Services.AddDbContext<AgendaContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("ConexaoPadrao"))
);

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers(); // Adiciona suporte a controllers

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// Mapeia as rotas dos controllers
app.MapControllers(); // Essa linha garante que os controllers sejam incluídos no pipeline de requisições


//var summaries = new[]
//{
//    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
//};

//app.MapGet("/weatherforecast", () =>
//{
//    var forecast =  Enumerable.Range(1, 5).Select(index =>
//        new WeatherForecast
 //       (
//            DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
//            Random.Shared.Next(-20, 55),
//            summaries[Random.Shared.Next(summaries.Length)]
//        ))
//        .ToArray();
//    return forecast;
//})
//.WithName("GetWeatherForecast")
//.WithOpenApi();

app.Run();

//record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
//{
//    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
//}
