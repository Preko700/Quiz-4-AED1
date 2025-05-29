using System;
using System.Collections.Generic;

public class Program
{
    /// <summary>
    /// Método 1: Función que verifica si dos strings son anagramas usando conteo de caracteres
    /// </summary>
    public static bool SonAnagramas(string str1, string str2)
    {
        // Si las longitudes son diferentes, no pueden ser anagramas
        if (str1.Length != str2.Length)
            return false;

        // Crear diccionarios para contar la frecuencia de cada caracter
        var contador1 = new Dictionary<char, int>();
        var contador2 = new Dictionary<char, int>();

        // Contar frecuencia de caracteres en str1
        foreach (char c in str1)
        {
            if (contador1.ContainsKey(c))
                contador1[c]++;
            else
                contador1[c] = 1;
        }

        // Contar frecuencia de caracteres en str2
        foreach (char c in str2)
        {
            if (contador2.ContainsKey(c))
                contador2[c]++;
            else
                contador2[c] = 1;
        }

        // Comparar las frecuencias
        foreach (var kvp in contador1)
        {
            if (!contador2.ContainsKey(kvp.Key) || contador2[kvp.Key] != kvp.Value)
                return false;
        }

        return true;
    }

    /// <summary>
    /// Método 2: Función alternativa usando ordenamiento de caracteres
    /// </summary>
    public static bool SonAnagramasAlternativo(string str1, string str2)
    {
        // Si las longitudes son diferentes, no pueden ser anagramas
        if (str1.Length != str2.Length)
            return false;

        // Ordenar ambos strings y comparar
        char[] arr1 = str1.ToCharArray();
        char[] arr2 = str2.ToCharArray();

        Array.Sort(arr1);
        Array.Sort(arr2);

        return new string(arr1) == new string(arr2);
    }

    public static void Main()
    {
        try
        {
            Console.WriteLine("Verificador de Anagramas");
            Console.WriteLine("----------------------");

            Console.WriteLine("Este programa determina si dos palabras son anagramas entre sí.");
            Console.WriteLine("(Dos palabras son anagramas si contienen exactamente los mismos caracteres pero en diferente orden)");

            bool continuar = true;

            while (continuar)
            {
                Console.Write("\nIngrese la primera palabra: ");
                string palabra1 = Console.ReadLine().Trim();

                Console.Write("Ingrese la segunda palabra: ");
                string palabra2 = Console.ReadLine().Trim();

                if (string.IsNullOrEmpty(palabra1) || string.IsNullOrEmpty(palabra2))
                {
                    Console.WriteLine("Las palabras no pueden estar vacías. Intente nuevamente.");
                    continue;
                }

                Console.WriteLine("\nVerificando usando método de conteo de caracteres:");
                bool resultado1 = SonAnagramas(palabra1, palabra2);
                Console.WriteLine($"\"{palabra1}\" y \"{palabra2}\" {(resultado1 ? "son" : "no son")} anagramas.");

                Console.WriteLine("\nVerificando usando método de ordenamiento:");
                bool resultado2 = SonAnagramasAlternativo(palabra1, palabra2);
                Console.WriteLine($"\"{palabra1}\" y \"{palabra2}\" {(resultado2 ? "son" : "no son")} anagramas.");

                Console.Write("\n¿Desea verificar otro par de palabras? (s/n): ");
                string respuesta = Console.ReadLine().ToLower();
                continuar = (respuesta == "s" || respuesta == "si" || respuesta == "sí");
            }

            Console.WriteLine("\n¡Gracias por usar el verificador de anagramas!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ocurrió un error: {ex.Message}");
        }
    }
}