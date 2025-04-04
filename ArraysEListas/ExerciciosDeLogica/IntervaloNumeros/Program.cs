// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

/*
Leia um valor inteiro N. Este valor será a quantidade de valores inteiros X que serão lidos em seguida.
Mostre quantos destes valores X estão dentro do intervalo [10,20] e quantos estão fora do intervalo, mostrando 
essas informações conforme exemplo (use a palavra "in" para dentro do intervalo, e "out" para fora do intervalo).
 */

Console.WriteLine("Informe um valor: ");
int N = int.Parse(Console.ReadLine());

int[] array = new int[N];

Console.WriteLine("Informe os valores: ");

for (int i = 0; i < N; i++)
{
    array[i] = int.Parse(Console.ReadLine());
}

int dentroIntervalo = 0;
int foraIntervalo = 0;

for (int i = 0; i < N; i++)
{
    if (array[i] >= 10 && array[i] <= 20)
    {
        dentroIntervalo++;
    }
    else
    {
        foraIntervalo++;
    }
}

Console.WriteLine("Valores dentro do intervalo: " + dentroIntervalo + " in");
Console.WriteLine("Valores fora do intervalo: " + foraIntervalo + " out");