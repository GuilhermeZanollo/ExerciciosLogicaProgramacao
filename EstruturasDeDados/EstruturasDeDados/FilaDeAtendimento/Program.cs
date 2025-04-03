// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Implemente uma fila de atendimento onde os usuários são atendidos na ordem de chegada. FIFO - First in First Out / Operações: Enqueue, Dequeue, Peek
// 

Queue<string> fila = new Queue<string>(); // fila genérica

while (true)
{
    Console.WriteLine("Escolha uma opção: ");
    Console.WriteLine("1 - Adicionar usuário à fila");
    Console.WriteLine("2 - Atender usuário");
    Console.WriteLine("3 - Exibir fila");
    Console.WriteLine("4 - Sair");

    string opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            Console.WriteLine("Digite o nome do usuário: ");
            string nome = Console.ReadLine();
            fila.Enqueue(nome); // adiciona um item ao final da fila.
            Console.WriteLine($"{nome} foi adicionado à fila.");
            break;

        case "2":
            if (fila.Count > 0)
            {
                string atendido = fila.Dequeue(); // Remove da fila e adiciona a variável atendido
                Console.WriteLine($"{atendido} foi atendido.");
            }
            else
            {
                Console.WriteLine("A fila está vazia");
            }
           break;
        
        case "3":
            if (fila.Count > 0)
            {
                Console.WriteLine("Fila de atendimento: ");
                foreach (var usuario in fila)
                {
                    Console.WriteLine(usuario);
                }
            }
            else
            {
                Console.WriteLine("A fila está vazia");
            }
            break;

        case "4":
            Console.WriteLine("Encerrando o programa...");
            return;

        default:
            Console.WriteLine("Opção inválida! Tente novamente.");
            break;
    }
}

