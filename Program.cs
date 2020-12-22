using System;
using POO_TarefaHeranca.Entities;

namespace POO_TarefaHeranca.Entities
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criação da Conta Jurídica
            ContaJuridica conta = new ContaJuridica(8010, "Lara Croft", 100.0, 500.0);
            //No console será exibido o valor de 100, equivalente ao saldo da conta criada
            Console.WriteLine(conta.Saldo);
        }
    }
}
