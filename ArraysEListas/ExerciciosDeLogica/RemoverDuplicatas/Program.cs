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

// Outra forma:

/*
int[] array = { 1, 1, 2, 2, 3 };

List<int> list = new List<int>(array);

list.Remove(2);
list.Remove(1);

foreach (int i in list)
{
    Console.WriteLine(i);
}
*/

// Outra forma:

/*
int[] array = { 1, 1, 2, 3, 4 };

List<int> list = new List<int>();

foreach (int numero in array)
{
    if(!list.Contains(numero))
    {
        list.Add(numero);
        Console.WriteLine(numero);
    }
}
*/