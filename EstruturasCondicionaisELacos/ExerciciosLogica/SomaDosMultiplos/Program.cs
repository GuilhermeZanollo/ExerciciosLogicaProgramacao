// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Some todos os múltiplos de 3 e 5 abaixo de 1000.
// Declarar 1000 números para baixo antes

int soma = 0;

for (int i = 0; i < 1000; i++)
{
    if (i % 3 == 0 || i % 5 == 0)
    {
        soma = soma + i;
    }
}

Console.WriteLine(soma);