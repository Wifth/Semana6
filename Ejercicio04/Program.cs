// See https://aka.ms/new-console-template for more information

using System.Diagnostics.CodeAnalysis;

int r1 = 0, r2 = 0, r3 = 0, num;

do
{
    Console.Write("Ingrese un número positivo: ");
    num = int.Parse(Console.ReadLine());

    if (num < 15)
        r1++;
    else if (num > 50)
        r2++;
    else if (num >= 25 && num <= 45)
        r3++;
} while (num > 0);

Console.WriteLine("Números menores que 15: " + r1);
Console.WriteLine("Números mayores que 50: " + r2);
Console.WriteLine("Números entre 25 y 45: " + r3);