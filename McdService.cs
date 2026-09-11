using System;

namespace MiApiCuadrado;

public class McdService
{
    public int CalcularMcd(int dividendo, int divisor)
    {
        while (divisor != 0)
        {
            int residuo = dividendo % divisor;
            dividendo = divisor;
            divisor = residuo;
        }
        return Math.Abs(dividendo);
    }
}