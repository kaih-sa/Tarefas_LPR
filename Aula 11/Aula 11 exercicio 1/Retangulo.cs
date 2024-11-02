using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_11_exercicio_1
{
    internal class Retangulo
    {

        public double altura;
        public double largura;

        public double calcArea(double parametro_altura, double parametro_largura)
        {
            double area = parametro_altura * parametro_largura;  
            return area;  
        }
        public double calcPerimetro(double parametro_altura, double parametro_largura)
        {
            double perimetro = 2 * parametro_altura + 2 * parametro_largura;
            return perimetro;
        }

    }
}
