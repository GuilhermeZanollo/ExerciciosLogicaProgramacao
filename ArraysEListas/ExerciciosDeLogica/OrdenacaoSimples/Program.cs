// See https://aka.ms/new-console-template for more information

// Ordenação Simples – Implemente o algoritmo de ordenação Bubble Sort ou Selection Sort.

int[] numeros = { 5, 3, 8, 4, 2 };

Console.WriteLine("Array original: " + string.Join(", ", numeros));
BubbleSort(numeros);
Console.WriteLine("Array ordenado: " + string.Join(", ", numeros));

static void BubbleSort(int[] array)
{
    int n = array.Length;
    bool trocou;

    for (int i = 0; i < n - 1; i++)
    {
        trocou = false;
        for (int j = 0; j < n - i - 1; j++)
        {
            if (array[j] > array[j + 1])
            {
                // Troca os elementos
                (array[j], array[j + 1]) = (array[j + 1], array[j]);
                trocou = true;
            }
        }
        if (!trocou) break; // Se não houve troca, a lista já está ordenada
    }
}

// Outra forma de resolver sem usar bubble sort:
/*
int[] numeros = { 5, 3, 8, 4, 2 };

Console.WriteLine("Array ordenado: " + string.Join(", ", numeros));

Array.Sort(numeros);

Console.WriteLine("Array ordenado: " + string.Join(", ", numeros));
*/

