using BityBank.Titular;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BityBank.Conta
{
    public class ContaCorrente
    {
        public int numero_agencia;
        public string conta;

        public double saldo = 100;

        public Cliente titular;


        public void Depositar(double valor)
        {
            saldo += valor;
        }
        public bool Saque(double valor)
        {
            if (valor <= saldo)
            {
                saldo -= valor;
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Transferir(double valor, ContaCorrente destino)
        {
            if (saldo < valor)
            {
                return false;
            }
            else
            {
                Saque(valor);
                destino.Depositar(valor);
                return true;
            }
        }

    }
}

