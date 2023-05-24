using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Modelos.Funcionarios
{
    public abstract class Funcionario
    {
        public string Nome { get; set; }
        public string Cpf { get; private set; }
        public double Salario { get; protected set; } 
        public static int TotalFuncionarios { get; protected set; }

        public Funcionario(string nome, string cpf, double salario)
        {
            this.Nome = nome;
            this.Cpf = cpf;
            this.Salario = salario;

            TotalFuncionarios++;
        }

        internal protected abstract double GetBonificacao();

        public abstract void AumentarSalario();
    }
}