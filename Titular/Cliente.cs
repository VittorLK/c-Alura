using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BityBank.Titular
{
    public class Cliente
    {
        public string nome;
        public string cpf;
        public string profissao;

        public static implicit operator string(Cliente v)
        {
            throw new NotImplementedException();
        }
    }
}
