

namespace Aula_11_exercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Retangulo objeto = new Retangulo();
            
            objeto.altura = double.Parse(Console.ReadLine());
            objeto.largura = double.Parse(Console.ReadLine());

            double area = objeto.calcArea(objeto.altura, objeto.largura);
           double perimetro = objeto.calcPerimetro(objeto.altura, objeto.largura);

            Console.WriteLine($"A área é {area} e seu perímetro é {perimetro}");
        }
    }
}
