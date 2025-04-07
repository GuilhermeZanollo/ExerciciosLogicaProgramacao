// See https://aka.ms/new-console-template for more information

/*
Contar o número de elementos de uma lista que atendem a uma condição:

Crie uma lista de inteiros e escreva um método que conte quantos números são maiores que um valor especificado.

Exemplo: Lista = { 1, 2, 3, 4, 5, 6 }, e o valor a ser comparado é 3. O resultado esperado é 3 (valores maiores que 3 são 4, 5, e 6).
 */

int[] array = { 1, 2, 3, 4, 5, 6 };
int contador = 0;

List<int> listaNumeros = new List<int>(array);

for (int i = 0; i < array.Length; i++)
{
    if(array[i] > 3)
    {
        contador++;
    }
}

Console.Write($"A lista possui {contador} numeros maiores que 3");