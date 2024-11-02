using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_11_exercicio_3
{
    internal class Aluno
    {
        private int matricula;
        private string nome;
        private double nota_prova1;
        private double nota_prova2;
        private double nota_trabalho;

        public Aluno(int matricula, string nome)
        {
            this.matricula = matricula;
            this.nome = nome;
        }

        public void Media()
        {
            double media = ((nota_prova1 * 2.5) + (nota_prova2 * 2.5) + (nota_trabalho * 2))/3;
            Console.WriteLine($"Média: {media}");
        }

        public string getNome()
        {
            return nome;
        }
        public int getMatricula()
        {
            return matricula;
        }
        public void setNotaProva1(double nota)
        {
            this.nota_prova1 = nota;
        }
        public void setNotaProva2(double nota)
        {
            this.nota_prova2 = nota;
        }
        public void setNotaTrabalho(double nota)
        {
            this.nota_trabalho = nota;
        }
        public double getNotaProva1()
        {
            return nota_prova1;
        }
        public double getNotaProva2()
        {
            return nota_prova2;
        }
        public double getNotaPrabalho()
        {
            return nota_trabalho;
        }

    }
}
