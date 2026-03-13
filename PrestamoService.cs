using System;
using System.Collections.Generic;

public class PrestamoService
{
    public decimal FondoDisponible = 10000000m;

  
    public bool ValidarMonto(decimal monto, decimal sueldo)
    {
        if (monto > sueldo * 4)
            return false;

        return true;
    }

   
    public bool ValidarGarantia(string garantia)
    {
        if (string.IsNullOrEmpty(garantia))
            return false;

        return true;
    }

    
    public bool ValidarFondos(decimal monto)
    {
        if (monto > FondoDisponible)
            return false;

        return true;
    }

  
    public decimal ObtenerTasa(int meses)
    {
        if (meses <= 12)
            return 0.1325m;

        if (meses <= 24)
            return 0.15m;

        return 0.30m;
    }

  
    public decimal CalcularInteresSimple(decimal monto, decimal tasa, int meses)
    {
        decimal tiempo = meses / 12m;

        decimal interes = monto * tasa * tiempo;

        return interes;
    }

    
    public decimal CalcularTotal(decimal monto, decimal interes)
    {
        return monto + interes;
    }

    public decimal CalcularCuota(decimal monto, decimal tasaAnual, int meses)
    {
        decimal i = tasaAnual / 12;

        decimal cuota = monto *
        (i * (decimal)Math.Pow((double)(1 + i), meses)) /
        ((decimal)Math.Pow((double)(1 + i), meses) - 1);

        return cuota;
    }

    
    public List<Amortizacion> GenerarAmortizacion(decimal monto, decimal tasa, int meses)
    {
        List<Amortizacion> tabla = new List<Amortizacion>();

        decimal saldo = monto;
        decimal cuota = CalcularCuota(monto, tasa, meses);

        for (int mes = 1; mes <= meses; mes++)
        {
            decimal interes = saldo * (tasa / 12);
            decimal amortizacion = cuota - interes;
            saldo -= amortizacion;

            tabla.Add(new Amortizacion
            {
                Mes = mes,
                Cuota = cuota,
                Interes = interes,
                AmortizacionCapital = amortizacion,
                Saldo = saldo
            });
        }

        return tabla;
    }


    public decimal CalcularMora(decimal cuota)
    {
        return cuota * 0.10m;
    }

    
    public bool EsClienteMoroso(int cantidadMoras)
    {
        if (cantidadMoras >= 3)
            return true;

        return false;
    }
}