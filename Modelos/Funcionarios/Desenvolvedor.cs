using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Modelos.Funcionarios
{
    public class Desenvolvedor : Funcionario
    {
        public Desenvolvedor(string nome, string cpf) 
            : base(nome, cpf, 3000)
        {
        }

        public override void AumentarSalario()
        {
            Salario *= 0.15;
        }

        internal protected override double GetBonificacao()
        {
            return Salario * 0.1;
        }
    }
}