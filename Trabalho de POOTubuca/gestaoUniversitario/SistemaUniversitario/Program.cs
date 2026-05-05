using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace SistemaUniversitario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== CONFIGURAÇÃO DA UNIDADE CURRICULAR ===");
            Console.Write("Nome da UC: ");
            string nomeUC = Console.ReadLine();
            Console.Write("Código da UC: ");
            string codigoUC = Console.ReadLine();

            UnidadeCurricular uc = new UnidadeCurricular
            {
                Nome = nomeUC,
               
            };


            Console.WriteLine("\n=== CADASTRO DO DOCENTE ===");
            Console.Write("Nome do Docente: ");
            string nomeDoc = Console.ReadLine();



            Console.WriteLine("\n=== INSCRIÇÃO DE ESTUDANTES ===");
            Console.Write("Quantos estudantes deseja inscrever? ");
            if (int.TryParse(Console.ReadLine(), out int numEst))
            {
                for (int i = 0; i < numEst; i++)
                {
                    Console.Write($"Nome do estudante {i + 1}: ");
                    string nomeEst = Console.ReadLine();
                    uc.InscreverEstudante(new Estudante
                    {
                        Nome = nomeEst,
                      
                    });
                }
            }


            Console.WriteLine("\n=== CONFIGURAÇÃO DE AVALIAÇÕES ===");
            Console.Write("Quantas avaliações terá a UC? ");
            if (int.TryParse(Console.ReadLine(), out int qtdAval))
            {
                for (int i = 0; i < qtdAval; i++)
                {
                    Console.WriteLine($"\nAvaliação {i + 1}:");
                    Console.WriteLine("1 - Teste");
                    Console.WriteLine("2 - Projecto");
                    Console.WriteLine("3 - Exame Final");
                    Console.Write("Escolha uma opção: ");
                    string opcao = Console.ReadLine();

                    Console.Write("Peso da avaliação (ex: 0,4 para 40%): ");
                    float peso = float.Parse(Console.ReadLine());

                    switch (opcao)
                    {
                        case "1":
                            Console.Write("Nota do Teste: ");
                            float nt = float.Parse(Console.ReadLine());
                            uc.AdicionarAvaliacao(new Testes(peso, nt));
                            break;
                        case "2":
                            Console.Write("Nota Prática: ");
                            float np = float.Parse(Console.ReadLine());
                            Console.Write("Nota Defesa: ");
                            float nd = float.Parse(Console.ReadLine());
                            uc.AdicionarAvaliacao(new Projecto(peso, np, nd));
                            break;
                        case "3":
                            Console.Write("Nota Exame Final: ");
                            float ne = float.Parse(Console.ReadLine());
                            uc.AdicionarAvaliacao(new ExameFinal(peso, ne));
                            break;
                        default:
                            Console.WriteLine("Opção inválida! Tente novamente esta avaliação.");
                            i--;
                            break;
                    }
                }
            }

            Console.Clear();
            uc.EmitirPauta();

            Console.WriteLine("Pressione qualquer tecla para encerrar o sistema...");
            Console.ReadKey();
        }
    }
}
