using System.Security;

namespace Operacao_Matematica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            string operacao;
            double n1,n2, resultado, resto;

            Console.WriteLine("Digite o seu primeiro nome:");
            name = Console.ReadLine();

            Console.WriteLine("Escolha a operação: (+ Soma, - Subtração, * Multiplicação, / Divisão, ^ Potência, v Raiz Quadrada)");
            operacao = Console.ReadLine();



            if (operacao == "v")
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
                }
            }
            else {

                Console.WriteLine("Digite o primeiro número");
                n1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite o segundo número");
                n2 = double.Parse(Console.ReadLine());

                switch (operacao)
                {
                    case "+":
                        resultado = n1 + n2;
                        Console.WriteLine($"A soma é :  {resultado} ");
                        break;

                    case "-":
                        resultado = n1 - n2;
                        Console.WriteLine($"A subtração é :  {resultado} ");
                        break;
                    case "/":
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
                        }
                        break;
                    case "*":
                        resultado = n1 * n2;
                        Console.WriteLine($" A Multiplicação é : {resultado}");
                        break;
                    case "^":
                        resultado = Math.Pow(n1, n2);
                        Console.WriteLine($"A Potenciação é : {resultado}");
                        break;
                    default:
                        Console.WriteLine("Operação não encontrada");
                        break;
                }
            }
        }
    }
}
