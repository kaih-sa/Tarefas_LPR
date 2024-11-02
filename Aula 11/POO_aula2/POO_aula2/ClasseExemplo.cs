using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_aula2
{
    public class ClasseExemplo
    {
       public int atributo; //deixar o atributo publico pra poder ter o acesso
       public string atributo2;
              string parametro;

        public void MetodoImprimir(string atributo)
        {
            Console.WriteLine(parametro);// Esse metodo faz parte de uma classe abstrata(static), ou seja classes
                                         // que não precisam instanciar ou criar objetos
        }

        public ClasseExemplo(int a1) //O construct é um método especial pra já definir um valor pra um atributo
        {
            int atributo1 = a1;
        }

    }
}
