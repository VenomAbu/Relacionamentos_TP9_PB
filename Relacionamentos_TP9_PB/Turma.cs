using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relacionamentos_TP9_PB
{
    internal class Turma
    {
        public int Codigo { get; set; }
        public Disciplina Disciplina { get; set; }

        public Turma(int codigo, Disciplina disciplina)
        {
            Disciplina = disciplina;
            Codigo = codigo;
        }

        public bool AbrirTurma()
        {
            Console.WriteLine("Turma " + Codigo + " aberta.");
            return true;
        }

        public bool GerarPauta()
        {
            Console.WriteLine("Pauta da turma " + Codigo + " aberta.");
            return true;
        }
    }
}
