using CalculadoraConsole;

namespace CalculadoraConsole
{
    public class Program {
        static void Main(string[] args)
        {
			CalculadoraMetodos calculadora = new CalculadoraMetodos();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Calculadora Console em C#\n");
                Console.WriteLine("Selecione uma operação:");
                Console.WriteLine("1. Adição");
                Console.WriteLine("2. Subtração");
                Console.WriteLine("3. Multiplicação");
                Console.WriteLine("4. Divisão");
                Console.WriteLine("5. Exibir Histórico");
                Console.WriteLine("6. Sair");

                if (!int.TryParse(Console.ReadLine(), out int opcao) || opcao < 1 || opcao > 6)
                {
                    Console.WriteLine("Opção inválida! Pressione qualquer tecla para tentar novamente.");
                    Console.ReadKey();
                    continue;
                }

                if (opcao == 6)
                {
                    break;
                }

                if (opcao == 5)
                {
                    Console.Clear();
                    Console.WriteLine("Histórico das últimas 3 operações:");
                    var historico = calculadora.ObterHistorico().ToList();
                    if (historico.Any())
                    {
                        foreach (var item in historico)
                        {
                            Console.WriteLine(item);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Nenhuma operação realizada.");
                    }
                    Console.WriteLine("Pressione qualquer tecla para continuar...");
                    Console.ReadKey();
                    continue;
                }

                Console.Write("Digite o primeiro número: ");
                if (!double.TryParse(Console.ReadLine(), out double num1))
                {
                    Console.WriteLine("Entrada inválida! Pressione qualquer tecla para tentar novamente.");
                    Console.ReadKey();
                    continue;
                }

                Console.Write("Digite o segundo número: ");
                if (!double.TryParse(Console.ReadLine(), out double num2))
                {
                    Console.WriteLine("Entrada inválida! Pressione qualquer tecla para tentar novamente.");
                    Console.ReadKey();
                    continue;
                }

                try
                {
                    double resultado = opcao switch
                    {
                        1 => calculadora.Adicao(num1, num2),
                        2 => calculadora.Subtracao(num1, num2),
                        3 => calculadora.Multiplicacao(num1, num2),
                        4 => calculadora.Divisao(num1, num2),
                        _ => throw new InvalidOperationException("Operação desconhecida")
                    };

                    Console.WriteLine($"Resultado: {resultado}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
        }
    }
}


