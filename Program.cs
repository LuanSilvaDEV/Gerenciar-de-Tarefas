//Importar as bibliotecas
using System;
using System.Collections.Generic;


//Criar a classe principal do programa
class Program
{
    //Cria uma lista do com dados tipo texto
    static List<string> tarefas = new List<string>();
    //Cria o menu de Interação
    static void main()
    {
        //Cria uma variavel do tipo inteiro
        int opcao = 0;

        //Cria uma estrutura de repetição "DO" e "WHILE"
        do
        {
            //Exibe mensagens na tela do usuario
            Console.WriteLine("\n=== GERENCIADOR DE TAREFAS ===");
            Console.WriteLine("1- ADD TAREFA");
            Console.WriteLine("1- LISTAR TAREFAS");
            Console.WriteLine("1- REMOVER TAREFAS");
            Console.Write("ESCOLHA UMA OPÇÃO: ");

            //Cria uma variavel do tipo String recebendo o valor inserido pelo usuario;
            string entrada = Console.ReadLine();
            if (!int.TryParse(entrada, out opcao))
            {
                Console.WriteLine("Digite um número válido!");
                continue; // Volta para o menu
            }

            //Cria uma opção para cada entrada do usuario "SWITCH" E "CASE"
            switch (opcao)
            {
                case 1:
                    AdicionarTarefa();
                    break;
                case 2:
                    ListarTarefas();
                    break;
                case 3:
                    RemoverTarefas();
                    break;
                case 0:
                    Console.WriteLine("Saindo...");
                    break;
                default:
                    Console.WriteLine("Opção invalida!");
                    break;
            }


        } while (opcao != 0); // Continua até o usuário digitar 0

    }

    //Cria as tarefas que precisam ser entregues ao usuario, tarefas essas colocadas na opções anterior do codigo dentro do (SWITCH, CASE);
    static void AdicionarTarefa()
    {
        //Mostrar na tela para que o usuario insira a tarefa que deseja armazenar;
        Console.WriteLine("Digite a Tarefa: ");
        //Cria uma variavel do tipo STRING recebendo o valor inserido pelo usuario;
        string tarefa = Console.ReadLine();
        //Coleta o dado inserido pelo usuario que está armazenado na variavel e adiciona a lista criada na linha 10
        tarefas.Add(tarefa);
        //Mostra ao usuario que a tarefa foi adicionada a lista com sucesso;
        Console.WriteLine("Tarefa Adicionada com Sucesso!");
    }

    static void ListarTarefas()
    {
        //Mostra a mensagem Lista de tarefas ao usuario;
        Console.WriteLine("\n --- Lista de Tarefas ---");
        //Cria condições para que, se a lista estiver vazia mostre uma mensagem ao usuario informando-o;
        if (tarefas.Count == 0)
        {
            Console.WriteLine("Nenhuma Tarefa Foi Encontrada");
        }
        //Se a lista tiver algo vai seer exibido cada tarefa com os numeros ao lado;
        else
        {
            for (int i = 0; i < tarefas.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {tarefas[i]}");
            }
        }
    }
    static void RemoverTarefas() {
        
    }
    


    

}






