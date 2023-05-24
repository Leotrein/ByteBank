using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Modelos.Funcionarios
{
    public class Designer : Funcionario
    {
        public Designer(string nome, string cpf) 
            : base(nome, cpf, 3000)
        {

        }

        internal protected override double GetBonificacao()
        {
            return Salario * 0.17;
        }

        public override void AumentarSalario()
        {
            Salario *= 1.11;
        }
    }
}