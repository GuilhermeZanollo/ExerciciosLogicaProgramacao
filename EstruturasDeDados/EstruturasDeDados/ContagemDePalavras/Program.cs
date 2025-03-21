// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Conte quantas vezes cada palavra aparece em um texto usando um Dictionary.

Console.WriteLine("Digite um texto:");
string texto = Console.ReadLine();

// Quebra o texto em palavras usando espaço como delimitador
string[] palavras = texto.Split(' ', StringSplitOptions.RemoveEmptyEntries);

// Dicionário para armazenar a contagem das palavras
Dictionary<string, int> contagemPalavras = new Dictionary<string, int>();

// Percorre cada palavra no texto
foreach (var palavra in palavras)
{
    // Converte para minúsculo para ignorar diferenciação entre maiúsculas e minúsculas
    string palavraNormalizada = palavra.ToLower();

    // Se a palavra já existir no dicionário, incrementa a contagem
    if (contagemPalavras.ContainsKey(palavraNormalizada))
    {
        contagemPalavras[palavraNormalizada]++;
    }
    else
    {
        // Caso contrário, adiciona a palavra ao dicionário com valor inicial 1
        contagemPalavras[palavraNormalizada] = 1;
    }
}

// Exibe a contagem das palavras
Console.WriteLine("\nContagem de palavras:");
foreach (var item in contagemPalavras)
{
    Console.WriteLine($"'{item.Key}': {item.Value}");
}