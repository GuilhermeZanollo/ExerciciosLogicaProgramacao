// See https://aka.ms/new-console-template for more information

// Potência – Implemente uma função recursiva para calcular.

Console.Write("Digite a base: ");
int baseNum = int.Parse(Console.ReadLine());

Console.Write("Digite o expoente: ");
int expoente = int.Parse(Console.ReadLine());

long resultado = Potencia(baseNum, expoente);
Console.WriteLine($"{baseNum} elevado à {expoente} é: {resultado}");


static long Potencia(int baseNum, int expoente)
{
    if (expoente == 0)  // Caso base: qualquer número elevado a 0 é 1
        return 1;
    else
        return baseNum * Potencia(baseNum, expoente - 1); // Chamada recursiva
}