// See https://aka.ms/new-console-template for more information

/*
Verificar se um elemento existe na lista:

Crie uma lista de strings e escreva um método que verifique se um determinado elemento está presente na lista.

Exemplo: Lista = { "C#", "Java", "Python", "JavaScript" }, e o elemento a ser verificado é "Python". O resultado deve ser true.
*/
/*
string[] array = { "C#", "Java", "Python", "JavaScript" };

foreach (string palavra in array)
{
    if (array.Contains("Java"))
    {
        Console.WriteLine("Está na lista.");
        break;
    } else
    {
        Console.WriteLine("Não está na lista");
    }
}
*/

// Segunda forma:
string[] array = { "C#", "Java", "Python", "JavaScript" };

Console.WriteLine("Informe uma palavra: ");
string palavra = Console.ReadLine();

for (int i = 0; i < array.Length; i++)
{
    if (array[i] == palavra)
    {
        Console.WriteLine("A palavra está no array");
        break;
    } 
}
/*
*/