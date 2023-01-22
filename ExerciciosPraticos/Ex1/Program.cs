using Ex1;
using System.Net.Mail;
using System.Runtime.Intrinsics.Arm;

Console.WriteLine("Insira o Nome do aluno:");
string nome = Console.ReadLine();

bool verificadorAno;
int ano;
do
{
    Console.WriteLine("Insira o ano do aluno:");
    bool convertAno = int.TryParse(Console.ReadLine(), out ano);
    if (convertAno && ano > 1964)
    {
        verificadorAno = true;
    }
    else
    {
        verificadorAno = false;
    }
} while (verificadorAno == false);

bool verificadorSemestre;
int semestre;
do
{
    Console.WriteLine("Insira o semestre do aluno:");
    bool convertSemestre = int.TryParse(Console.ReadLine(), out semestre);
    if (convertSemestre && (semestre >= 1 && semestre <= 14))
    {
        verificadorSemestre = true;
    }
    else
    {
        verificadorSemestre = false;
    }
} while (verificadorSemestre == false);


Boletim boletim = new Boletim(nome, ano, semestre);

boletim.RegistrarNotas(10);
boletim.RegistrarNotas(5);
boletim.RegistrarNotas(6);
boletim.RegistrarNotas(6);
boletim.RegistrarNotas(6);
boletim.RegistrarNotas(0);


boletim.CalcularMediaSemestral();



