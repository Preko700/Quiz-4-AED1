using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    /// <summary>
    /// Función que une intervalos traslapados
    /// </summary>
    /// <param name="intervals">Arreglo de pares que representan intervalos</param>
    /// <returns>Arreglo de intervalos unidos</returns>
    public static int[][] UnirIntervalos(int[][] intervals)
    {
        // Si hay 0 o 1 intervalo, retornar tal cual
        if (intervals.Length <= 1)
            return intervals;

        // Ordenar los intervalos por su punto de inicio
        Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));

        // Lista para almacenar el resultado
        var resultado = new List<int[]>();
        resultado.Add(intervals[0]);

        for (int i = 1; i < intervals.Length; i++)
        {
            var intervaloActual = intervals[i];
            var ultimoIntervalo = resultado[resultado.Count - 1];

            // Verificar si hay traslape
            if (intervaloActual[0] <= ultimoIntervalo[1])
            {
                // Unir intervalos: actualizar el fin del último intervalo al máximo entre los dos
                ultimoIntervalo[1] = Math.Max(ultimoIntervalo[1], intervaloActual[1]);
            }
            else
            {
                // No hay traslape, agregar el intervalo actual al resultado
                resultado.Add(intervaloActual);
            }
        }

        return resultado.ToArray();
    }

    public static void Main()
    {
        try
        {
            Console.WriteLine("Programa para unir intervalos traslapados");
            Console.WriteLine("----------------------------------------");
            Console.Write("¿Cuántos intervalos desea ingresar? ");
            int cantidadIntervalos = int.Parse(Console.ReadLine());

            if (cantidadIntervalos <= 0)
            {
                Console.WriteLine("Debe ingresar al menos un intervalo.");
                return;
            }

            int[][] intervalos = new int[cantidadIntervalos][];

            Console.WriteLine("\nIngrese cada intervalo en formato 'inicio,fin':");

            for (int i = 0; i < cantidadIntervalos; i++)
            {
                Console.Write($"Intervalo {i + 1}: ");
                string entrada = Console.ReadLine();

                string[] valores = entrada.Split(',');
                if (valores.Length != 2)
                {
                    Console.WriteLine("Formato inválido. Debe ingresar dos números separados por coma.");
                    i--; // Repetir este índice
                    continue;
                }

                try
                {
                    int inicio = int.Parse(valores[0]);
                    int fin = int.Parse(valores[1]);

                    if (inicio > fin)
                    {
                        Console.WriteLine("El inicio debe ser menor o igual al fin del intervalo.");
                        i--; // Repetir este índice
                        continue;
                    }

                    intervalos[i] = new int[] { inicio, fin };
                }
                catch (FormatException)
                {
                    Console.WriteLine("Por favor ingrese números válidos.");
                    i--; // Repetir este índice
                }
            }

            Console.WriteLine("\nIntervalos ingresados:");
            ImprimirIntervalos(intervalos);

            Console.WriteLine("\nResultado después de unir intervalos traslapados:");
            int[][] resultado = UnirIntervalos(intervalos);
            ImprimirIntervalos(resultado);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ocurrió un error: {ex.Message}");
        }
    }

    // Función helper para imprimir los intervalos
    private static void ImprimirIntervalos(int[][] intervals)
    {
        foreach (var interval in intervals)
        {
            Console.Write($"[{interval[0]},{interval[1]}] ");
        }
        Console.WriteLine();
    }
}