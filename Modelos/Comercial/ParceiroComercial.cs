using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Modelos.Servicos;

namespace Modelos.Comercial
{
    public class ParceiroComercial
    {
        private string Senha { get; set; }
        private AutenticacaoHelper _autenticacao = new AutenticacaoHelper();

        public ParceiroComercial(string senha)
        {
            this.Senha = senha;
        }

        public bool Autenticar(string senha)
        {
            return _autenticacao.CompararSenhas(Senha, senha);
        }
    }
}