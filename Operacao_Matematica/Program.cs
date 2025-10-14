using System.Security;

namespace Operacao_Matematica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            string operacao = "";
            double n1, n2, resultado, resto;
            int contador;

            List<String> historico = new List<string>();

            Console.WriteLine("\n Digite o seu primeiro nome:");
            name = Console.ReadLine();

            while (true)
            {
                
                Console.WriteLine("Escolha a operação: ");
                Console.WriteLine("1 - Soma");
                Console.WriteLine("2 - Subtração");
                Console.WriteLine("3 - Divisão");
                Console.WriteLine("4 - Multiplicação");
                Console.WriteLine("5 - Potência");
                Console.WriteLine("6 - Raiz Quadrada");
                Console.WriteLine("7 - Ver Histórico");
                Console.WriteLine("8 - Tabuada");
                Console.WriteLine("9 - Média");
                Console.WriteLine("0 - Sair");
                
                operacao = Console.ReadLine();

                if (operacao == "0")
                    break;

                if (operacao == "7")
                {
                    if (historico.Count == 0)
                    {
                        Console.WriteLine("Nenhuma operação realizada ainda.");
                    }
                    else
                    {
                        int count = 1;
                        Console.WriteLine("\n Histórico de Operações");
                        foreach (string item in historico)
                        {
                            Console.WriteLine($"{count} - {item}");
                            count++;
                        }
                    }
                    continue;
                }

                if (operacao == "6")
                {
                    Console.WriteLine("Digite o número que deseja saber a Raiz Quadrada: ");
                    n1 = double.Parse(Console.ReadLine());

                    if (n1 < 0)
                    {
                        Console.WriteLine("Não é possivel calcular a raiz de numeros menores do que zero");
                    }
                    else
                    {
                        resultado = Math.Sqrt(n1);
                        Console.WriteLine($"A rais quadrada do número é : {resultado}");
                        historico.Add($"√{n1} = {resultado}");
                    }
                    continue;
                }

                if(operacao ==  "8")
                {
                    Console.WriteLine("Digite o número para Obeter a Tabuada:");
                    n1 = double.Parse(Console.ReadLine());

                    Console.WriteLine($"\nTabuada de {n1}");
                    for (contador = 1; contador <= 10; contador++)
                    {
                        resultado = n1 * contador;
                        Console.WriteLine($" {n1} X {contador} = {resultado}");
                    }
                    historico.Add($"Tabuada do {n1}");
                    continue;
                }

                if(operacao == "9")
                {
                    Console.WriteLine("Quantos números deseja saber a média?");
                    int qtdNumeros = int.Parse(Console.ReadLine());
                    double soma = 0;

                    for(contador = 1; contador <= qtdNumeros; contador++)
                    {
                        Console.WriteLine($"Digite o {contador}º número:");
                        double numero = double.Parse(Console.ReadLine());
                        soma += numero;
                    }

                    double media = soma / qtdNumeros;
                    Console.WriteLine($"\n média dos {qtdNumeros} números é: {media}");
                    historico.Add($"Média de {qtdNumeros} números = {media}");
                    continue;
                }

                if (operacao != "6") {

                    Console.WriteLine("Digite o primeiro número");
                    n1 = double.Parse(Console.ReadLine());

                    Console.WriteLine("Digite o segundo número");
                    n2 = double.Parse(Console.ReadLine());

                    switch (operacao)
                    {

                        case "1":
                            resultado = n1 + n2;
                            Console.WriteLine($"A soma é :  {resultado} ");
                            historico.Add($"{n1} + {n2} = {resultado}");
                            break;

                        case "2":
                            resultado = n1 - n2;
                            Console.WriteLine($"A subtração é :  {resultado} ");
                            historico.Add($"{n1} - {n2} = {resultado}");
                            break;
                        case "3":
                            if (n1 == 0 || n2 == 0)
                            {
                                Console.WriteLine("Não é possivel dividir por zero");
                            }
                            else
                            {
                                resultado = n1 / n2;
                                resto = n1 % n2;
                                Console.WriteLine($"A Divisão é :  {resultado}");
                                Console.WriteLine($"O resto da divisão é: {resto}");
                                historico.Add($"{n1} / {n2} = {resultado} (Resto: {resto})");
                            }
                            break;
                        case "4":
                            resultado = n1 * n2;
                            Console.WriteLine($" A Multiplicação é : {resultado}");
                            historico.Add($"{n1} * {n2} =  {resultado}");
                            break;
                        case "5":
                            resultado = Math.Pow(n1, n2);
                            Console.WriteLine($"A Potenciação é : {resultado}");
                            historico.Add($"{n1} ^ {n2} = {resultado}");
                            break;
                        default:
                            Console.WriteLine("Operação não encontrada");
                            break;
                    }                                              
                    
                }
            }
        }          
    }
}
