// See https://aka.ms/new-console-template for more information

// Calcule o fatorial de um número usando recursão.

Console.Write("Digite um número: ");
int numero = int.Parse(Console.ReadLine());

long resultado = Fatorial(numero);
Console.WriteLine($"O fatorial de {numero} é: {resultado}");

static long Fatorial(int n)
{
    if (n == 0 || n == 1)
        return 1; // Caso base: fatorial de 0 e 1 é sempre 1
    else
        return n * Fatorial(n - 1); // Chama a própria função com (n - 1)
}

