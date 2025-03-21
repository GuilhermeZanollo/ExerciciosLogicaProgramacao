// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// (Undo) – Simule um sistema de "desfazer" usando uma pilha (Stack). // LIFO LAST IN FIRST OUT / Operações: Push, Pop, Peek

Stack<string> historico = new Stack<string>(); 

while (true)
{
    Console.WriteLine("\nEscolha uma opção: ");
    Console.WriteLine("1 - Adicionar ação");
    Console.WriteLine("2 - Desfazer última ação");
    Console.WriteLine("3 - Mostrar histórico");
    Console.WriteLine("4 - Sair");

    string opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            Console.WriteLine("Digite a ação realizada: ");
            string acao = Console.ReadLine();
            historico.Push(acao); // Push adiciona um item no topo da pilha.
            Console.WriteLine($"Ação '{acao}' adicionada.");
            break;

        case "2":
            if (historico.Count > 0)
            {
                string ultimaAcao = historico.Pop(); // Desfaz a última ação
                Console.WriteLine($"Desfeito: {ultimaAcao}");
            }
            else
            {
                Console.WriteLine("Nenhuma ação para desfazer.");
            }
            break;

        case "3":
            Console.WriteLine("\nHistórico de ações:");
            foreach (var acaoHist in historico)
            {
                Console.WriteLine(acaoHist);
            }
            break;

        case "4":
            Console.WriteLine("Saindo...");
            return;

        default:
            Console.WriteLine("Opção inválida.");
            break;
    }
}