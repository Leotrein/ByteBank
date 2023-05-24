using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Modelos.Servicos
{
    public interface IAutenticavel
    {
        bool Autenticar(string senha);
    }
}