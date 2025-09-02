using System.Security;

namespace Operacao_Matematica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            string operacao;
            int n1,n2;
            double resultado;

            Console.WriteLine("Digite o seu primeiro nome:");
            name = Console.ReadLine();

            Console.WriteLine("Escolha a operação: (+ Soma, - Subtração, * Multiplicação, / Divisão, ^ Potência)");
            operacao = Console.ReadLine();

            Console.WriteLine("Digite o primeiro número");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número");
            n2 = int.Parse(Console.ReadLine());


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
                        Console.WriteLine($"A Divisão é :  {resultado}");
                    }
                     break;                    
                case "*":
                    resultado = n1 * n2;
                    Console.WriteLine($" A Multiplicação é : {resultado}");
                    break;
                case "^":
                    resultado = Math.Pow( n1, n2 );
                    Console.WriteLine($"A Potenciação é : {resultado}");
                    break;
                default:
                    Console.WriteLine("Operação não encontrada");
                    break;
            }
        }
    }
}
