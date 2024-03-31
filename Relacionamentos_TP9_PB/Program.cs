using System.Threading.Channels;

namespace Relacionamentos_TP9_PB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Disciplina d1 = new Disciplina(1, "Java");
            Disciplina d2 = new Disciplina(2, "C#");
            Disciplina d3 = new Disciplina(3, "Projeto de Bloco");

            Professor p1 = new Professor(1, "Ricardo", d1);
            Professor p2 = new Professor(2, "Elberth", d2);
            Professor p3 = new Professor(3, "Luiz", d3);

            List<Aluno> alunos = new List<Aluno>();

            alunos.Add(new Aluno(1, "Danillo"));
            alunos.Add(new Aluno(2, "Calebe"));
            alunos.Add(new Aluno(1, "André"));

            List<Turma> turmas = new List<Turma>();

            turmas.Add(new Turma(1, d1));
            turmas.Add(new Turma(2, d2));
            turmas.Add(new Turma(3, d3));

            Console.WriteLine("Exibição dos Professores:");

            Console.WriteLine("Nome: " + p1.Nome);
            Console.WriteLine("Disciplina: " + p1.Disciplina.Nome);
            Console.WriteLine();

            Console.WriteLine("Nome: " + p2.Nome);
            Console.WriteLine("Disciplina: " + p2.Disciplina.Nome);
            Console.WriteLine();

            Console.WriteLine("Nome: " + p3.Nome);
            Console.WriteLine("Disciplina: " + p3.Disciplina.Nome);
            Console.WriteLine();


            Console.WriteLine("Exibição das Disciplinas:");

            Console.WriteLine("Nome: " + d1.Nome);
            Console.WriteLine("Codigo: " + d1.Codigo);
            Console.WriteLine();

            Console.WriteLine("Nome: " + d2.Nome);
            Console.WriteLine("Codigo: " + d2.Codigo);
            Console.WriteLine();

            Console.WriteLine("Nome: " + d3.Nome);
            Console.WriteLine("Codigo: " + d3.Codigo);
            Console.WriteLine();

            Console.WriteLine("Alocando alunos:");
            foreach (var aluno in alunos)
            {
                Console.WriteLine("Aluno: " + aluno.Nome);

                if (aluno.AddTurma(turmas[0]))
                {
                    Console.WriteLine(aluno.Nome + " adicionado à turma " + turmas[0].Codigo + ".");
                }

                if (aluno.AddTurma(turmas[1]))
                {
                    Console.WriteLine(aluno.Nome + " adicionado à turma " + turmas[1].Codigo + ".");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("Exibindo as turmas dos alunos:");

            foreach (var aluno in alunos)
            {
                Console.WriteLine("Aluno: " + aluno.Nome);
                Console.WriteLine(aluno.ExibirTurmas());
                Console.WriteLine() ;
            }
        }
    }
}
