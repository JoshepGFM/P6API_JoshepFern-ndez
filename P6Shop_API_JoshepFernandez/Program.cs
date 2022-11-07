using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using P6Shop_API_JoshepFernandez.Models;

public class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        //creacion de la configuracion contra el entorno

        // Add services to the container.

        builder.Services.AddControllers();

        //OBTENEMOS LA INFO DE LA CADENA DE CONEXION DESDE EL ARCHIVO DE CONFIGURACION
        //APPSETTING.JSON. EL NOMBRE DE LA ETIQUETA ES CNNSTR
        var CnnStrBuilder = new SqlConnectionStringBuilder(builder.Configuration.GetConnectionString("CNNSTR"));

        string conn = CnnStrBuilder.ConnectionString;

        //var conn = @"SERVER=JOSHEP; DATABASE=P6SHOPPING;INTEGRATED SECURITY=TRUE; User Id=;Password=";

        builder.Services.AddDbContext<P6SHOPPINGContext>(options => options.UseSqlServer(conn));

        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseRouting();

        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}