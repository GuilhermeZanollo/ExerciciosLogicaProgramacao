// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Verifique se um número é primo.

Console.Write("Digite um número: ");
int numero = int.Parse(Console.ReadLine());

if (numero < 2)
{
    Console.WriteLine($"{numero} não é um número primo.");
    return;
}

bool primo = true;

for (int i = 2; i < numero; i++)
{
    if (numero % i == 0)
    {
        primo = false;
        break;
    }
}

if (primo)
    Console.WriteLine($"{numero} é um número primo.");
else
    Console.WriteLine($"{numero} não é um número primo.");

