// See https://aka.ms/new-console-template for more information

int num;

do
{
    Console.WriteLine("Ingrese un número: ");
    num = int.Parse(Console.ReadLine());

} while (num >= 0);