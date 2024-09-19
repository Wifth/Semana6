// See https://aka.ms/new-console-template for more information

using System.Diagnostics.CodeAnalysis;

int num, suma = 0;

do
{
    Console.WriteLine("Ingrese un número: ");
    num = int.Parse(Console.ReadLine());

    if (num > 0)
        suma += num;

} while (num != 0);

Console.WriteLine("Suma de positivos: " + suma);