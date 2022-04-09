using System;
using System.Globalization;

namespace ExercicioFConta
{
    internal class Program
    {
        static void Main(string[] args)
        {    
            double deposito, saque;

            Console.Write("Entre o número da conta: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            string name = Console.ReadLine();
            
            Console.Write("Hávera depósito inicial (s/n)? ");
            char caracter = char.Parse(Console.ReadLine());
            Console.WriteLine();

            if(caracter == 's' || caracter == 'S')
            {
                Console.Write("Entre o valor de déposito inicial: ");
                deposito = double.Parse(Console.ReadLine());
                
                Conta conta = new Conta(id, name, deposito);
                Console.WriteLine(conta);
                
                Console.Write("Informe saque: ");
                saque = double.Parse(Console.ReadLine());
                conta.Saque(saque);

                Console.WriteLine("Dados da conta atualizados: ");
                Console.WriteLine(conta);
            }
            if(caracter == 'n' || caracter == 'N')
            {
                Conta conta2 = new Conta(id, name);
                Console.WriteLine("Dados da conta:");
                Console.WriteLine(conta2);

                Console.WriteLine();
                Console.Write("Entre o valor de déposito: ");
                deposito = double.Parse(Console.ReadLine());
                conta2.Depositar(deposito);
                
                Console.WriteLine("Dados da conta atualizados: ");
                Console.WriteLine(conta2);
                Console.WriteLine();

                Console.Write("Informe saque: ");
                saque = double.Parse(Console.ReadLine());
                conta2.Saque(saque);

                Console.WriteLine("Dados da conta atualizados: ");
                Console.WriteLine(conta2);
            }

        }
    }
}
