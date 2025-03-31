// See https://aka.ms/new-console-template for more information


// Gerenciador de Lista de Tarefas - Crie um programa que permita adicionar, listar e remover tarefas de uma lista.

using System.ComponentModel.Design;

List<string> tarefas = new List<string>();

while (true)
{
    Console.WriteLine("ESCOLHA UMA DAS OPÇÕES: ");
    Console.WriteLine("1- Para adicionar uma tarefa");
    Console.WriteLine("2- Para listar tarefas");
    Console.WriteLine("3- Para remover tarefa");

    if (!int.TryParse(Console.ReadLine(), out int opcao))
    {
        Console.WriteLine("Opção inválida");
        continue;
    }

    switch (opcao)
    {
        case 1:
            Console.WriteLine("Informe o nome da tarefa: ");
            string nomeTarefa = Console.ReadLine();
            tarefas.Add(nomeTarefa);
            Console.WriteLine("Tarefa adicionada com sucesso!");
            break;

        case 2:
            if (tarefas.Count > 0)
            {
                foreach (string t in tarefas)
                {
                    Console.WriteLine(t);
                }
            }
            else
            {
                Console.WriteLine("Lista está vazia");
            }
            break;

        case 3:
            if (tarefas.Count > 0)
            {
                Console.WriteLine("Lista de tarefas: ");
                for (int i = 0; i < tarefas.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {tarefas[i]}");
                }

                Console.WriteLine("Informe o número da tarefa que deseja remover: ");
                int index = int.Parse(Console.ReadLine());
                if (index > 0 && index <= tarefas.Count)
                {
                    tarefas.RemoveAt(index - 1);
                }
                else
                {
                    Console.WriteLine("Essa tarefa não existe");
                }
            }
            else
            {
                Console.WriteLine("Lista está vazia");
            }
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }
}

