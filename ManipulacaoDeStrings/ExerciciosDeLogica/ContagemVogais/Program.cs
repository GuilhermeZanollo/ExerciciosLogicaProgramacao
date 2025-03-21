// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Conte quantas vogais existem em uma string fornecida pelo usuário.
// Lógica: Entrada de uma palavra

Console.WriteLine("Informe uma palavra: ");
string palavra = Console.ReadLine();
int contador = 0;

foreach (char letra in palavra)
{
    if (("aeiou".Contains(letra))) {
        contador++;
    }
}

Console.WriteLine("A palabra possui: " + contador);