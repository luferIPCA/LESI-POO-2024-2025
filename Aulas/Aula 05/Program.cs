namespace Aula_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculadora a = new Calculadora();
            a.X = 1;
            a.Y = 2;

            int resultado = a.Soma();
            int resultado2 = a.Soma(3, 7);
        }
    }
}
