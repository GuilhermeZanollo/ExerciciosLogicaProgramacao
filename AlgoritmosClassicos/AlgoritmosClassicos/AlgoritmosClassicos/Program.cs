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

bool ehPrimo = true;

for (int i = 2; i < numero; i++)
{
    if (numero % i == 0)
    {
        ehPrimo = false;
        break;
    }
}

if (ehPrimo)
    Console.WriteLine($"{numero} é um número primo.");
else
    Console.WriteLine($"{numero} não é um número primo.");
    }