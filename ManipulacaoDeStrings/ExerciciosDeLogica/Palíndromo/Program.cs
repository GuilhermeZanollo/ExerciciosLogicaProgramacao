// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Verifique se uma palavra digitada pelo usuário é um palíndromo.
// Lógica: Uma entrada de palavra

Console.WriteLine("Informe uma palavra: ");
string palavra = Console.ReadLine();

char[] palavraSeparada = palavra.ToCharArray();
Array.Reverse(palavraSeparada);
string palavraInvertida = new string(palavraSeparada);

if (palavraInvertida ==  palavra)
{
    Console.WriteLine("Palavra é um palíndromo");
} else
{
    Console.WriteLine("Palavra não é um palíndromo");
}