using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Categoria : Base
    {

        public Categoria(string nome, string descricao)
        {
            Nome = nome;
            Descricao = descricao;
        }

        public string? Nome { get; private set; }
        public string? Descricao { get; private set; }

    }
}