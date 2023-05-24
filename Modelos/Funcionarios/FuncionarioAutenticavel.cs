using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Modelos.Servicos;

namespace Modelos.Funcionarios
{
    public abstract class FuncionarioAutenticavel : Funcionario, IAutenticavel
    {
        private string Senha { get; set; }
        private AutenticacaoHelper _autenticacao = new AutenticacaoHelper();
        
        public FuncionarioAutenticavel(string nome, string cpf, double salario, string senha) 
            : base(nome, cpf, salario)
        {
            this.Senha = senha;
        }

        public virtual bool Autenticar(string senha)
        {
            return _autenticacao.CompararSenhas(Senha, senha);
        }
    }
}