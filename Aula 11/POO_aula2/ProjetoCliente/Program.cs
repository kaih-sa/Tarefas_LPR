using POO_aula2;// assim como as bibliotecas que a gnt usa, isso avisa que vai utilizar desta

namespace ProjetoCliente//Projeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClasseExemplo objetodocliente = new ClasseExemplo();
            objetodocliente.atributo2 = "Cliente";
            objetodocliente.MetodoImprimir(objetodocliente.atributo2);


        }
    }
}
