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


        } while (opcao != 0);
        
    }



}






