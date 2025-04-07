// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Verifique se um número informado pelo usuário está presente em um array pré-definido.
// Lógica: entrada de um número , definir um array 


int[] array = {10, 20, 30, 50, 60};

Console.WriteLine("Informe um número inteiro: ");
int numero = int.Parse(Console.ReadLine());

for (int i = 0; i < array.Length; i++)
{
    if (numero == array[i])
    {
        Console.WriteLine("Acertou o número");
    }
}

