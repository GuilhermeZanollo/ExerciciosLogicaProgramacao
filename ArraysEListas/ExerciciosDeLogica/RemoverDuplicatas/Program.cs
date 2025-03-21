// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Dado um array, remova os números repetidos e exiba o resultado.
// Lógica: Definir um array e remover os números repetidos

int[] numeros = { 1, 1, 2, 3, 4, 4 }; // defino array

List<int> numerosUnicos = new List<int>(); // defino lista

foreach (int numero in numeros)
{
    if (!numerosUnicos.Contains(numero))
    {
        numerosUnicos.Add(numero);
    }
}

foreach (int numero in numerosUnicos)
{
    Console.WriteLine(numero);
}
