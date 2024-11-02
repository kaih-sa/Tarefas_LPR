namespace Aula_11_exercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario1 = new("Kaio",1200);
            funcionario1.AumentarSalario(100);
            funcionario1.MostrarDados();
        }
    }
}
