using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Modelos.Servicos
{
    public class SistemaInterno
    {
        public bool Logar(IAutenticavel usuario, string senha)
        {
            if (usuario.Autenticar(senha))
            {
                Console.WriteLine("Bem-vindo(a) ao sistema!");
                return true;
            }
            Console.WriteLine("Senha incorreta!");
            return false;
        }
    }
}