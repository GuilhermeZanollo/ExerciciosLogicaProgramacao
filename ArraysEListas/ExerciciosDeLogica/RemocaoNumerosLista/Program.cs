// See https://aka.ms/new-console-template for more information

/*
Remover todos os números pares de uma lista:

Dada uma lista de inteiros, remova todos os números pares da lista.

Exemplo: Lista = { 1, 2, 3, 4, 5, 6 }. A lista após remoção dos pares deve ser { 1, 3, 5 }.
*/

int[] array = { 1, 2, 3, 4, 5, 6 };

List<int> list = new List<int>();

for (int i = 0; i < array.Length; i++)
{
    if (i % 2 != 0)
    {
        list.Add(i);
    }
}

Console.WriteLine("Array: " + string.Join(", ", list));
