// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Conte quantas vogais existem em uma string fornecida pelo usuário.
// Lógica: Entrada de uma palavra

/*
Console.WriteLine("Informe uma palavra: ");
string palavra = Console.ReadLine();
int contador = 0;

foreach (char letra in palavra)
{
    if (("aeiou".Contains(letra))) {
        contador++;
    }
}

Console.WriteLine("A palavra possui: " + contador);
*/

// Segunda forma:

Console.WriteLine("Informe uma palavra: ");
string palavra = Console.ReadLine();
int contador = 0;

for (int i = 0; i < palavra.Length; i++)
{
    char letra = char.ToLower(palavra[i]); // garante que funcione com letras maiúsculas também
    if ("aeiou".Contains(letra))
    {
        contador++;
    }
}

Console.WriteLine("A palavra possui: " + contador + " vogais.");