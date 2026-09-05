using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Dapper;
using MiApiCuadrado.Models;

namespace MiApiCuadrado.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EstudiantesController : ControllerBase
{
    private readonly IConfiguration _config;

    public EstudiantesController(IConfiguration config)
    {
        _config = config;
    }

    [HttpGet]
    public IActionResult GetEstudiantes()
    {
        string? connectionString = _config.GetConnectionString("DefaultConnection");

        using (var connection = new SqlConnection(connectionString))
        {
            string sql = "SELECT * FROM Estudiantes";
            
            var estudiantes = connection.Query<Estudiante>(sql);
            
            return Ok(estudiantes);
        }
    }
    [HttpPost]
public IActionResult GuardarEstudiante([FromBody] Estudiante estudiante)
{
    string? connectionString = _config.GetConnectionString("DefaultConnection");
    
    using (var connection = new SqlConnection(connectionString))
    {
        string sql = "INSERT INTO Estudiantes (Nombre, Apellido) VALUES (@Nombre, @Apellido)";
        
        var filasAfectadas = connection.Execute(sql, estudiante);
        
        if (filasAfectadas > 0)
        {
            return Ok("Estudiante guardado exitosamente");
        }
        
        return BadRequest("No se pudo guardar el registro");
    }
}
}