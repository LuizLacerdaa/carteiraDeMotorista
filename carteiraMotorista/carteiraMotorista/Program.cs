using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carteiraMotorista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            Console.Write("Você possui carteira de motorista? (S/N): ");
            string possuiCarteira = Console.ReadLine().ToLower();

            if (idade >= 18 && possuiCarteira == "s")
            {
                Console.WriteLine("Você é elegivel para dirigir");
            }
            else Console.WriteLine("Você não é elegivel para dirigir");
            
                  
            Console.ReadKey();  
        }
    }
}
