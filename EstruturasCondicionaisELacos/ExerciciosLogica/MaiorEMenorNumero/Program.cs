// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// O usuário insere 10 números e o programa deve exibir o maior e o menor deles.
// Raciocínio: Entrada de 10 números e saída do maior e menor deles.

Console.WriteLine("Informe 10 números: ");

int[] numeros = new int[10];

for (int i = 0; i < numeros.Length; i++)
{
    numeros[i] = int.Parse(Console.ReadLine());
}

int maiorNumero = numeros[0];
int menorNumero = numeros[0];

for (int i = 0;i < numeros.Length;i++)
{
    if (numeros[i] > maiorNumero)
        maiorNumero = numeros[i];
    if (numeros[i] < menorNumero)
        menorNumero= numeros[i];
}

Console.WriteLine("Menor número: " + menorNumero);
Console.WriteLine("Maior número: " +  maiorNumero);

