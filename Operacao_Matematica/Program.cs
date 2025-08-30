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

            Console.WriteLine("Escolha a operação a ser feita (+.-./.*)");
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
                default:
                    Console.WriteLine("Operação não encontrada");
                    break;
            }
        }
    }
}
