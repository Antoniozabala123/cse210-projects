using System;
using System.Collections.Generic;
using System.Linq;

namespace ScriptureMemorizer;

class Program
{
    static void Main(string[] args)
    {
        // 1. Configuración inicial
        Reference reference = new Reference("Proverbios", 3, 5, 6);
        Scripture scripture = new Scripture(reference, "Fíate de Jehová de todo tu corazón y no te apoyes en tu propia prudencia");

        string input = "";

        // 2. Bucle principal
        while (input.ToLower() != "quit" && !scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPresiona Enter para ocultar palabras o escribe 'quit' para salir:");

            input = Console.ReadLine();

            if (input.ToLower() != "quit")
            {
                scripture.HideRandomWords(3); // Oculta 3 palabras cada vez
            }
        }

        // Mostrar el estado final antes de cerrar
        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("\n¡Felicidades! Has terminado.");
    }
}