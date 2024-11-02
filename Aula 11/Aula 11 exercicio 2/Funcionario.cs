using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Aula_11_exercicio_2
{
    internal class Funcionario
    {
        string nome;
        double salario_bruto;
        public Funcionario(string nome, double salario_bruto)
        {
            this.nome = nome;
            this.salario_bruto = salario_bruto;
        }

        public void MostrarDados()
        {
           switch(salario_bruto)
            {
                case <= 2000:
                Console.WriteLine($"Nome: {nome};\nSalário líquido: {salario_bruto*0.9}");
                    break;
                case <= 3000:
                    Console.WriteLine($"Nome: {nome};\nSalário líquido: {salario_bruto * 0.85}");
                    break;
                default:
                    Console.WriteLine($"Nome: {nome};\nSalário líquido: {salario_bruto * 0.8}");
                    break;

            }
            
        }

        public void AumentarSalario(double porcentagem)
        {
            double salario_liquido = salario_bruto * porcentagem/100;
            Console.WriteLine($"Salário atualizado: {salario_liquido}");
        }
    }   
}



