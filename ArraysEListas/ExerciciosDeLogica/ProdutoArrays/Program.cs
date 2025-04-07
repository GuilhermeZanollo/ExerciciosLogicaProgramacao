// See https://aka.ms/new-console-template for more information

/*
Multiplicar todos os elementos de um array:

Dado um array de números inteiros, escreva um método que retorne o produto de todos os elementos.

Exemplo: Array = { 2, 3, 4 }. O resultado esperado é 24 (2 * 3 * 4).
*/

int[] ints = { 2, 3, 4 };

int multiplicacao = 1;

foreach (int i in ints)
{
    multiplicacao = multiplicacao * i;
}

Console.WriteLine(multiplicacao);



