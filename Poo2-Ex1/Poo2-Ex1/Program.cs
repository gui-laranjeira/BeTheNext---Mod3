using Poo2_Ex1;

Pessoa pessoa = new Pessoa("Guilherme", 23);

pessoa.Cumprimentar();
pessoa.DizerIdade();
Console.WriteLine();

Aluno aluno = new Aluno("Beatriz", 21);

aluno.IrParaEscola();
aluno.Cumprimentar();
aluno.DizerIdade();
Console.WriteLine();

Professor professor = new Professor("Michael", 30);

professor.Cumprimentar();
professor.DizerIdade();
professor.Explicar("Primeira guerra mundial");
