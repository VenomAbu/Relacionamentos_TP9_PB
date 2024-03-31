using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relacionamentos_TP9_PB
{
    internal class Disciplina
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }

        public Disciplina(int codigo, string nome)
        {
            Codigo = codigo;
            Nome = nome;
        }
    }
}
