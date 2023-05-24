using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Modelos.Funcionarios
{
    public class Diretor : FuncionarioAutenticavel
    {
        public Diretor(string nome, string cpf, string senha) 
            : base(nome, cpf, 5000, senha)
        {

        }

        internal protected override double GetBonificacao()
        {
            return Salario * 0.50;
        }

        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }
    }
}