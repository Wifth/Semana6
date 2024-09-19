// See https://aka.ms/new-console-template for more information

int num, i = 0, p = 0, n = 0;

do
{
    Console.Write("Ingresar un número: ");
    num = int.Parse(Console.ReadLine());

    if (num % 2 == 0 && num != 0)
        p++;
    else if (num % 2 != 0 && num != 0)
        i++;   
} while (num > 0);

Console.WriteLine("\n\nCantidad de pares: " + p);
Console.WriteLine("Cantidad de impares: " + i);