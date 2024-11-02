namespace POO_aula2//Projeto
{
    internal class Program
    {
        static void Main(string[] args)//Esse main significa que aqui que começa, já que o código vai fluir, por isso tem só um
        {
            ClasseExemplo objetodaclasse = new ClasseExemplo(); // criar objeto desse tipo, ou melhor, classe
            objetodaclasse.atributo2 = "Zé"; // dar um valor a um objeto através de um atributo
            objetodaclasse.MetodoImprimir(objetodaclasse.atributo2); //chamar a função 

        }
    }
}
