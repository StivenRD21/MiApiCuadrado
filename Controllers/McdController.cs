using Microsoft.AspNetCore.Mvc;

namespace MiApiCuadrado.Controllers;

[ApiController]
[Route("api/[controller]")]
public class McdController : ControllerBase
{
    [HttpGet]
    public IActionResult Calcular(int a, int b)
    {
        var servicio = new McdService();
        int resultado = servicio.CalcularMcd(a, b);
        
        return Ok(new 
        { 
            Dividendo = a, 
            Divisor = b, 
            MCD = resultado 
        });
    }
}