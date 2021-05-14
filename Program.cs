using System;

namespace cadasprod2
{
    class Program
    {
        static void Main(string[] args)
        {
            MostrarMenu();
        }
        
        static bool fzrdnv = false;
        static string[] nome = new string[10];
        static float[] preço = new float[10];
        static double[] promoção = new double[10];
        static double[] valor = new double[10];
        static int i = 0;
        static void CadastrarProduto()
        {
            bool carabrr = false;
            bool repetição = false;
            bool cadasmais = false;

            Console.WriteLine("Bem vindo a página de cadastro!!");

            do
            {
                do
                {
                    Console.WriteLine("Qual o nome do produto que você deseja cadastrar?");
                    nome[i] = Console.ReadLine();

                    Console.WriteLine("Qual o preço desse produto?");
                    preço[i] = float.Parse(Console.ReadLine());


                    do
                    {
                        Console.WriteLine("Este produto vai possuir desconto?(sim ou não)");
                        string resposta = Console.ReadLine().ToLower();

                        if (resposta == "sim")
                        {
                            Console.WriteLine("Qual o valor do desconto/promoção?(digite a porcentagem, ex:0,30 para 30%)");
                            promoção[i] = double.Parse(Console.ReadLine());

                            valor[i] = (preço[i] * ( 1 - promoção[i]));

                            Console.WriteLine($"o novo vlaor do produto é R$ {valor[i]}");
                            carabrr = false;
                        }
                        else if (resposta == "não")
                        {
                            Console.WriteLine("Ok então o valor de seu produto é o indicado a cima");
                            valor[i] = preço[i];
                        }
                        else
                        {
                            Console.WriteLine("A resposta inserida não é valida, responda novamente.");
                        }
                    } while (carabrr);


                    Console.WriteLine("Deseja cadastrar mais um produto?(responder com Sim ou Não)");
                    string rep = Console.ReadLine().ToLower();

                    if (rep == "sim")
                    {
                        repetição = false;
                        cadasmais = true;
                    }
                    else if (rep == "não")
                    {
                        Console.WriteLine("Ok, você será direcionado ao menu, tenha um bom dia");
                        repetição = false;
                        cadasmais = false;
                    }
                    else
                    {
                        Console.WriteLine("A resposta inserida não é valida, responda novamente.");
                    }
                } while (cadasmais);

                i++;
            } while (repetição);

        }
        static void ListarProduto()
        {
            Console.WriteLine("Listagem de produtos");
            for (var a = 0; a < i; a++)
            {
                Console.WriteLine($"{a + 1}º Produto");
                Console.WriteLine($"Produto: {nome[a]}");
                Console.WriteLine($"Preço: {preço[a]}");
                Console.WriteLine($"Desconto: {promoção[a]}");
                Console.WriteLine($"Preço futuro: {valor[a]}");

                
            }
        }
        static void MostrarMenu()
        {
            do
            {
                Console.WriteLine(@"
            Para executar uma ação, digite um dos numeros a seguir:
            1 para cadastrar um novo produto
            2 para listar os produts cadastrados
            0 para sair");
                int escolhamenu = int.Parse(Console.ReadLine());

                switch (escolhamenu)
                {
                    case 1:
                        CadastrarProduto();
                        fzrdnv = true;
                        break;
                    case 2:
                        ListarProduto();
                        fzrdnv = true;
                        break;
                    case 0:
                        Console.WriteLine("Ok, você deseja sair");
                        fzrdnv = false;
                        break;
                    default:
                        break;
                }
            } while (fzrdnv);


        }
    }
}
