// See https://aka.ms/new-console-template for more information

// Fibonacci – Gere a sequência de Fibonacci até o n-ésimo termo usando recursão.

{
    Console.Write("Digite um número para a sequência de Fibonacci: ");
    int n = int.Parse(Console.ReadLine());

    Console.WriteLine($"Sequência de Fibonacci até o {n}-ésimo termo:");
    for (int i = 0; i < n; i++)
    {
        Console.Write(Fibonacci(i) + " ");
    }
}

static int Fibonacci(int n)
{
    if (n == 0) return 0; // Caso base 1: Fibonacci(0) = 0
    if (n == 1) return 1; // Caso base 2: Fibonacci(1) = 1
    return Fibonacci(n - 1) + Fibonacci(n - 2); // Chamada recursiva
}