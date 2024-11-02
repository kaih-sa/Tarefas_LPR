namespace Aula_11_exercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno1 = new(1234,"Kaio");
            aluno1.setNotaProva1(12);
            aluno1.setNotaProva2(25);
            aluno1.setNotaTrabalho(58);
            aluno1.Media();


        }
    }
}
