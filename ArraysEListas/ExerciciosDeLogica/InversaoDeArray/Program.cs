// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Receba um array de números e exiba os números na ordem inversa.
// Lógica: Entrada Array de números e saída ordem inversa

Console.WriteLine("Quantos números deseja informar? ");
int quantidadeNumeros = int.Parse(Console.ReadLine());

int[] numeros = new int[quantidadeNumeros];

for (int i = 0; i < quantidadeNumeros; i++)
{
    Console.WriteLine($"Informe o {i + 1}º número: ");
    numeros[i] = int.Parse(Console.ReadLine());
}

Array.Reverse(numeros);

foreach (int numero in numeros)
{
    Console.WriteLine(numero);
}


// Segunda forma:
/*
Console.WriteLine("Quantos números deseja informar? ");
int quantidadeNumeros = int.Parse(Console.ReadLine());

int[] numeros = new int[quantidadeNumeros];

for (int i = 0; i < quantidadeNumeros; i++)
{
    Console.WriteLine($"Informe o {i + 1}º número: ");
    numeros[i] = int.Parse(Console.ReadLine());
}

for (int i = quantidadeNumeros - 1; i >= 0; i--)
{
    Console.WriteLine(numeros[i]);
}
*/