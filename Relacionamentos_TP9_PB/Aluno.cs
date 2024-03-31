using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relacionamentos_TP9_PB
{
    internal class Aluno
    {
        public int Matricula { get; set; }
        public String Nome { get; set; }
        public List<Turma> Turmas { get; set; }


        public Aluno(int matricula, string nome)
        {
            Matricula = matricula;
            Nome = nome;
            Turmas = new List<Turma>();
        }

        public bool AddTurma(Turma turma)
        {
            Turmas.Add(turma);
            Console.WriteLine(Nome + " adicionado à turma " + turma.Codigo + ".");
            return true;
        }

        public string ExibirTurmas()
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var turma in Turmas)
            {
                stringBuilder.Append("Turma: " + turma.Codigo + "\n" + "Disciplina: " + turma.Disciplina.Nome + "\n");
            }

            return stringBuilder.ToString();
            // PS: Esse Visual Studio é bom mesmo, completou o  StringBuilder quase sozinho.
        }
    }
}
