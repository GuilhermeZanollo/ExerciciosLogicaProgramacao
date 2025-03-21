// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("Informe a palavra: ");
string palavra = Console.ReadLine();

char[] palavraSeparada = palavra.ToCharArray();
Array.Reverse(palavraSeparada);
string palavraInvertida = new string(palavraSeparada);

