using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controleContas
{
    class Agencia
    {
        public int AgeNum { get; private set; }
        public string Cep { get; private set; }
        public string Telefone { get; private set; }

        public Agencia(int agenum, string cep, string telefone)
        {
            AgeNum = agenum;
            if (cep.Length != 8)
                throw new System.ArgumentException("*** CEP INVÁLIDO ***");
            if (telefone.Length != 11)
                throw new System.ArgumentException("*** TELEFONE INVÁLIDO ***");
            Cep = cep;
            Telefone = telefone;
        }


    }
}
