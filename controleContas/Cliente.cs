using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controleContas
{
    class Cliente
    {
        public string Nome { get; private set; }
        public int AnoNascimento { get; private set; }
        public string Cpf { get; private set; }
        
        public Cliente(string nome, int anoNascimento, string cpf)
        {
            if (Int32.Parse(DateTime.Now.ToString("yyy")) - anoNascimento < 18)
                throw new System.ArgumentException("*** CLIENTE DEVE TER MAIS DE 18 ANOS ***");
            if (cpf.Length != 11)
                throw new System.ArgumentException("*** CPF PRECISA TER 11 DÍGITOS ***");
            Nome = nome;
            AnoNascimento = anoNascimento;
            Cpf = cpf;
        }
    }
}
