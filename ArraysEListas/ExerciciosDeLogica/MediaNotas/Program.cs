// See https://aka.ms/new-console-template for more information

/*
3.Média de Notas
Solicite ao usuário que informe 5 notas e calcule a média delas. Exiba também a maior e a menor nota digitadas.
 */

using System.Globalization;

double[] notas = new double[3];
Console.WriteLine("Informe 3 notas: ");
double soma = 0;

for (int i = 0; i < notas.Length; i++)
{
    notas[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

}

foreach (double nota in notas)
{
    soma += nota;
}

double media = soma / notas.Length;

Console.WriteLine("A média das notas é: " + media.ToString("F1", CultureInfo.InvariantCulture));

double maiorNumero = notas[0];
double menorNumero = notas[0];

for (int i = 0; i < notas.Length; i++)
{
    if (notas[i] > maiorNumero)
        maiorNumero = notas[i];
    if (notas[i] < menorNumero)
        menorNumero = notas[i];
}

Console.WriteLine($"O maior número do array é: " + maiorNumero.ToString("F1", CultureInfo.InvariantCulture));
Console.WriteLine($"O menor número do array é: " + menorNumero.ToString("F1", CultureInfo.InvariantCulture));
