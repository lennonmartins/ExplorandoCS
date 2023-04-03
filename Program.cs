using EXEMPLOEXPLRANDO.Models;



string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");

foreach(string linha in linhas){
    Console.WriteLine(linha);
}

// Pessoa pessoa = new Pessoa(nome: "Lennon", sobrenome:"Martins");
// Pessoa pessoa2 = new Pessoa("Camila", "Vitoria"  );

// Curso cursoDeIngles = new Curso();
// cursoDeIngles.NomeCurso = "Inglês";
// cursoDeIngles.Alunos = new List<Pessoa>();

// cursoDeIngles.adicionarAluno(pessoa);
// cursoDeIngles.adicionarAluno(pessoa2);
// cursoDeIngles.listarAlunos();
