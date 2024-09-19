// See https://aka.ms/new-console-template for more information

using System.ComponentModel.Design;

Random r = new Random();
int num = r.Next(1, 21), n, intentos = 0;

Console.WriteLine(num);
Console.WriteLine("*******************************\n");
Console.WriteLine("\tBienvenido.");
Console.WriteLine("\tVamos a jugar!");
Console.WriteLine("\n********************************");
Console.WriteLine("Intente adivinar el número sacado al azar\n\n");

do
{
    Console.Write("Ingrese su número: ");
    n = int.Parse(Console.ReadLine());
    if (num == n)
    {
        Console.WriteLine("");
        Console.WriteLine("\n********************************");
        Console.WriteLine("\tNúmero adivinado!");
        Console.WriteLine("\tFelicidades!");
        Console.WriteLine("\n********************************");
        break;
    }
    else if (n != num && n > num)
    {
        Console.WriteLine("Tu número es mayor que el sacado.\n");
        intentos++;
    }
    else if (n != num && n < num)
    {
        Console.WriteLine("Tu número es menor que el sacado.\n");
        intentos++;
    }


} while (intentos < 3);

Console.WriteLine("Juego terminado.");