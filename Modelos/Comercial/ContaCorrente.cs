using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Modelos.Excecoes;

namespace Modelos.Comercial
{
    public class ContaCorrente
    {
        public static double TaxaOperacional { get; private set; }
        public static int TotalContas { get; private set; }
        public int TransferenciasInvalidas { get; private set; }
        public Cliente Titular { get; set; }
        public double Agencia { get; }
        public int Numero { get; }
        private double _saldo;
        public double Saldo
        {
            get
            {
                return _saldo;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Valor inválido, não pode ser menor que 0");
                }
                _saldo = value;
            }
        }

        public ContaCorrente(Cliente titular, int agencia, int numero)
        {
            if (agencia == 0)
            {
                throw new ArgumentException("O argumento não deve ser igual a 0.", nameof(agencia));
            }
            else if (numero == 0)
            {
                throw new ArgumentException("O argumento não deve ser igual a 0.", nameof(numero));
            }
            this.Titular = titular;
            this.Agencia = agencia;
            this.Numero = numero;

            TotalContas++;
            TaxaOperacional = 30 / TotalContas;
        }

        public void Sacar(double valor)
        {
            if (this.Saldo < valor)
            {
                throw new SaldoInsuficienteException(
                    $"Saldo insuficiente para a operação no valor de {valor}"
                    , this.Saldo
                    , valor
                );
            }
            this.Saldo -= valor;
        }

        public void Depositar(double valor)
        {
            this.Saldo += valor;
        }

        public void Transferir(double valor, ContaCorrente contaDestino)
        {
            try
            {
                Sacar(valor);
            }
            catch(SaldoInsuficienteException e)
            {
                TransferenciasInvalidas++;
                throw new OperacaoFinanceiraException("Operação não realizada", e);
            }
            contaDestino.Depositar(valor);
        }

        public override bool Equals(object? obj)
        {
            return obj is ContaCorrente conta &&
                   Cliente.Equals(this.Titular, conta.Titular) &&
                   Agencia == conta.Agencia &&
                   Numero == conta.Numero;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Titular, Agencia, Numero);
        }
    }
}