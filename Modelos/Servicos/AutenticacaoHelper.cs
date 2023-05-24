using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Servicos
{
    internal class AutenticacaoHelper
    {
        internal bool CompararSenhas(string senha, string senhaTentativa)
        {
            return senha == senhaTentativa;
        }
    }
}
