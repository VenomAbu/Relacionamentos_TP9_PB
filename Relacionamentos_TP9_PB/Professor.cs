using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Relacionamentos_TP9_PB
{
    internal class Professor
    {
        public int Matricula { get; set; }
        public string Nome { get; set; }
        public Disciplina Disciplina { get; set; }

        public Professor(int matricula, string nome, Disciplina disciplina)
        {
            Matricula = matricula;
            Nome = nome;
            Disciplina = disciplina;
        }
    }
}
