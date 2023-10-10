using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        List<string> nomes = new List<string>();
        bool continuar = true;

        while (continuar)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Adicionar nome");
            Console.WriteLine("2. Listar nomes");
            Console.WriteLine("3. Sair");
            Console.Write("Escolha uma opção: ");

            int opcao;
            if (!int.TryParse(Console.ReadLine(), out opcao))
            {
                Console.WriteLine("Opção inválida.");
                continue;
            }

            switch (opcao)
            {
                case 1:
                    Console.Write("Digite um nome: ");
                    nomes.Add(Console.ReadLine());
                    break;

                case 2:
                    Console.WriteLine("Nomes:");
                    foreach (var nome in nomes)
                    {
                        Console.WriteLine(nome);
                    }
                    break;

                case 3:
                    continuar = false;
                    break;

                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }
    }
}
