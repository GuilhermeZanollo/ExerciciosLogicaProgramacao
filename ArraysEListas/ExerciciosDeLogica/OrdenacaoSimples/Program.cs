// See https://aka.ms/new-console-template for more information

// Ordenação Simples – Implemente o algoritmo de ordenação Bubble Sort ou Selection Sort.

int[] numeros = { 5, 3, 8, 4, 2 };

Console.WriteLine("Array original: " + string.Join(", ", numeros));
BubbleSort(numeros);
Console.WriteLine("Array ordenado: " + string.Join(", ", numeros));

static void BubbleSort(int[] array)
{
    bool trocou;

    for (int i = 0; i < array.Length - 1; i++) // Controla o número de passagens sobre o array
    {
        trocou = false;
        for (int j = 0; j < array.Length - i - 1; j++) // Compara elementos adjacentes e os troca se necessário.
        {
            if (array[j] > array[j + 1]) // Verifica se o elemento atual (array[j]) é maior que o próximo (array[j + 1])
            {
                // Troca os elementos
                (array[j], array[j + 1]) = (array[j + 1], array[j]); // Troca os elementos usando tuple de atribuição
                trocou = true;
            }
        }
        if (!trocou) break; // Se não houve troca, a lista já está ordenada
    }
}

/*
// Outra forma de resolver sem usar bubble sort:

int[] numeros = { 5, 3, 8, 4, 2 };

Console.WriteLine("Array ordenado: " + string.Join(", ", numeros));

Array.Sort(numeros);

Console.WriteLine("Array ordenado: " + string.Join(", ", numeros));
*/

