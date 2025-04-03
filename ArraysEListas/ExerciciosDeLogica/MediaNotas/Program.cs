// See https://aka.ms/new-console-template for more information

/*
3.Média de Notas
Solicite ao usuário que informe 5 notas e calcule a média delas. Exiba também a maior e a menor nota digitadas.
 */

using System.Globalization;

double[] notas = new double[5];
Console.WriteLine("Informe 5 notas: ");
double soma = 0;

for (int i = 0; i < 5; i++)
{
    notas[i] = double.Parse(Console.ReadLine());

}

foreach (double i in notas)
{
    Console.WriteLine(i);
    soma = soma + i;
}

Console.WriteLine(soma);

double media = soma / notas.Length;

Console.WriteLine("A média das notas é: " + media.ToString("F1", CultureInfo.InvariantCulture));
