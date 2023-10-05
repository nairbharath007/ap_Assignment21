using AbstractFactoryLibrary.Model;

namespace AbstractFactoryConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICarFactory TeslaSUVFactory = new SUVFactory();
            ITesla TeslaSUV = TeslaSUVFactory.CreateTesla();
            TeslaSUV.Start();
            TeslaSUV.Stop();

            Console.WriteLine(new String('-',30));

            ICarFactory TeslaSedanFactory = new SedanFactory();
            ITesla TeslaSedan = TeslaSedanFactory.CreateTesla();
            TeslaSedan.Start();
            TeslaSedan.Stop();

            Console.WriteLine(new String('-',30));

        }
    }
}