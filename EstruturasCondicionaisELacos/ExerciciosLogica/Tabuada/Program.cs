// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Exiba a tabuada de um número inserido pelo usuário
// Raciocinio: Entrada de um número, saída: tabuada desse número

Console.WriteLine("Informe o número da tabuada que deseja: ");
int numero = int.Parse(Console.ReadLine());

for (int i = 0; i <= 10; i++)
{
    int resultado = numero * i;
    Console.WriteLine($"{numero} x {i} = " + resultado);
}