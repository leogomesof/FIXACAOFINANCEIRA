using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controleContas
{
    class Conta
    {
        //private int _numero; //só pode ser usada dentro da conta (atributo, começa com _)

        public long Numero { get; private set; }

        public decimal Saldo { get; set; }

        public Cliente Titular { get; set; }

        public Agencia Local { get; set; }

        public Conta (int numero, Cliente titular)
        {
            if (numero < 999) //exceção para tratar
            {
                throw new System.ArgumentException("O número da conta deve ser superior à 999");
            }
            Numero = numero;
            Titular = titular;
        }

        public void SaldoInicial(decimal valor)
        {
            if (valor < 10.0m)
            {
                throw new System.ArgumentException("*** VALOR ABAIXO DE R$10,00 ***");
            }
            Saldo = valor; 
        }
        public void Depositar(decimal valor) //retorna nada, mas altera o saldo
        {
            Saldo += valor; //manipulando a propiedade
        }

        public bool Sacar(decimal valor)
        {
            if ((Saldo - valor - 0.1m) < 0)
            {
                Console.WriteLine("\n*** VALOR INVÁLIDO ***");
                return false;
            }
            Saldo -= valor + 0.1m;
            return true;
        }

        public bool Transferir(Conta destino, decimal valor) //sacar de uma conta e depositar na outra
        {
            if (Sacar(valor)) //já retorna true 
            {
                destino.Depositar(valor);
                return true;
            }
            Console.WriteLine("TRANSFERÊNCIA NÃO REALIZADA");
            return false;
        }

        /*//Preciso criar uma propiedade para manipular esses números
        public int Numero  //propiedade com métodos de acesso (Controlar acesso). Posso consultar/ modificar as informações
        {
            get 
            {
                return _numero;
            }
            set 
            {
                _numero = value; //mandando número para o get
            }
        }*/
    }
}
