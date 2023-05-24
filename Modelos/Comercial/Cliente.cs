using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Modelos.Comercial
{
    public class Cliente
    {
        public static int totalClientes { get; private set; } = 0;
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Profissao { get; set; }

        public Cliente(string nome, string cpf, string profissao)
        {
            this.Nome = nome;
            this.Cpf = cpf;
            this.Profissao = profissao;

            totalClientes++;
        }

        public override bool Equals(object? obj)
        {
            return obj is Cliente cliente &&
                   Cpf == cliente.Cpf;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Nome, Cpf, Profissao);
        }
    }
}