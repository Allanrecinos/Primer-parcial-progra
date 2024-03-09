using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Mostrar mensaje de bienvenida
            Console.WriteLine("Bienvenido al programa de generación de correos electrónicos.");

            // Solicitar ingreso de correo electrónico de dominio gmail
            Console.Write("Por favor ingrese su correo electrónico de dominio gmail: ");
            string correoGmail = Console.ReadLine();

            // Generar nuevo correo con dominio miumg.edu.gt
            string[] partesCorreo = correoGmail.Split('@');
            if (partesCorreo.Length == 2 && partesCorreo[1] == "gmail.com")
            {
                string nuevoCorreo = partesCorreo[0] + "@miumg.edu.gt";
                Console.WriteLine($"El nuevo correo generado es: {nuevoCorreo}");
            }
            else
            {
                Console.WriteLine("El correo electrónico ingresado no es válido o no pertenece a gmail.");
            }
        }
    }
}