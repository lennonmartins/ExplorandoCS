using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXEMPLOEXPLRANDO.Models
{
    public class Curso
    {
        public string NomeCurso { get; set; }
        public List<Pessoa> Alunos { get; set; }

        public void adicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }

        public int obterQuantidadeDeAlunos()
        {
            return Alunos.Count;
        }

        public void removerAlunos(Pessoa aluno)
        {
            Alunos.Remove(aluno);
        }

        public void listarAlunos(){
            Console.WriteLine($"Alunos matriculado no curso de {NomeCurso}");
            for(int count=0 ; count < Alunos.Count; count ++){
                string texto = "Nº " + count + " - " + Alunos[count].NomeCompleto;
                Console.WriteLine(texto);
            }
        }
    }
}
