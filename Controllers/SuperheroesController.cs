using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Dapper;
using MiApiCuadrado.Models;

namespace MiApiCuadrado.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SuperheroesController : ControllerBase
{
    private readonly IConfiguration _config;

    public SuperheroesController(IConfiguration config)
    {
        _config = config;
    }

    [HttpGet]
    public IActionResult GetSuperheroes()
    {
        string? connectionString = _config.GetConnectionString("DefaultConnection");
        
        using (var connection = new SqlConnection(connectionString))
        {
            string sql = "SELECT * FROM Superheroes";
            var heroes = connection.Query<Superheroe>(sql);
            return Ok(heroes);
        }
    }

    [HttpPost]
    public IActionResult GuardarSuperheroe([FromBody] Superheroe heroe)
    {
        string? connectionString = _config.GetConnectionString("DefaultConnection");
        
        using (var connection = new SqlConnection(connectionString))
        {
            string sql = "INSERT INTO Superheroes (NombreHeroe, NombreReal, Poder) VALUES (@NombreHeroe, @NombreReal, @Poder)";
            
            var filasAfectadas = connection.Execute(sql, heroe);
            
            if (filasAfectadas > 0)
            {
                return Ok("Superhéroe guardado exitosamente");
            }
            
            return BadRequest("No se pudo guardar el registro");
        }
    }
}