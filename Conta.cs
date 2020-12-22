using System;
using System.Collections.Generic;
using System.Text;
using POO_TarefaHeranca.Entities;

namespace POO_TarefaHeranca.Entities
{
    class Conta
    {
        //Declarações das variáveis e uso do encapsulamento
        public int Numero { get; private set; }
        public string Titular { get; private set; }
        //Utilização do protected para alteração de valores entre classes
        public double Saldo { get; protected set; }
        //Criação do construtor padrão e construtor com parâmetros
        public Conta() { }
        public Conta(int numero, string titular, double saldo)
        {
            Numero = numero; 
            Titular = titular; 
            Saldo = saldo;
        }
        //Método de Saque
        public void Saque(double saldoTotal)
        {
            Saldo -= saldoTotal;
        }
        //Método de Deposito
        public void Deposito(double saldoTotal)
        {
            Saldo += saldoTotal;
        }
    }
}

