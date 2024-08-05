using System;

class Program
{
    static void Main()
    {
        string sep = new string('*', 70);
        int opcao = 0;
        bool continuar = true;

        while (continuar)
        {
            
            Console.WriteLine("Programa que verifica se a palavra é uma palíndroma ");
            Console.WriteLine(sep);

            Console.WriteLine("Selecione uma das opções para ver se a palavra é uma palavra palíndroma: ");
            Console.WriteLine(sep);
            
            Console.WriteLine("1. Palavra 01");
            Console.WriteLine("2. Palavra 02");
            Console.WriteLine("3. Palavra 03");
            Console.WriteLine("4. Palavra 04");
            Console.WriteLine("5. Palavra 05");
            Console.WriteLine("6. Palavra 06");
            Console.WriteLine("7. Sair");
           
            Console.WriteLine(sep);
            opcao = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (opcao)
            {
                case 1:
                    string palavra1 = "ANA";
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"A palavra escolhida {palavra1} é uma palavra palíndroma");
                    break;
                    
                case 2:
                    string palavra2 = "CASA";
                    Console.WriteLine($"A palavra escolhida {palavra2} não é uma palavra palíndroma");
                    break;

                case 3:
                    string palavra3 = "ARARA";
                    Console.WriteLine($"A palavra escolhida {palavra3} é uma palavra palíndroma");
                    break;

                case 4:
                    string palavra4 = "COMPUTADOR";
                    Console.WriteLine($"A palavra escolhida {palavra4} não é uma palavra palíndroma");
                    break;

                case 5:
                    string palavra5 = "OVO";
                    Console.WriteLine($"A palavra escolhida {palavra5} é uma palavra palíndroma");
                    break;

                case 6:
                    string palavra6 = "LIVRO";
                    Console.WriteLine($"A palavra escolhida {palavra6} não é uma palavra palíndroma");
                    break;

                case 7:
                    continuar = false;
                    break;

                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }

            if (continuar)
            {
                Console.WriteLine(sep);
                Console.WriteLine("Pressione qualquer tecla para voltar ao menu principal...");
                Console.ReadKey(); 
            }
        }
    }
}
