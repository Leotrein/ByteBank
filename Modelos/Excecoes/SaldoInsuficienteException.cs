using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Modelos.Excecoes
{
    public class SaldoInsuficienteException : Exception
    {
        public double Saldo { get; private set; }
        public double Valor { get; private set; }

        public SaldoInsuficienteException()
        {

        }

        public SaldoInsuficienteException(string? message) : base(message)
        {

        }

        public SaldoInsuficienteException(string? message, double saldo, double valor)
            : this(message) 
        {
            this.Saldo = saldo;
            this.Valor = valor;
        }

        public SaldoInsuficienteException(string? message, Exception? innerException) 
            : base(message, innerException)
        {

        }
    }
}