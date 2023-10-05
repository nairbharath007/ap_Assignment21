using FacadeLibrary;

namespace FacadeConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HotelReception Reception = new HotelReception();

            Console.WriteLine("Getting Indian Menu:");
            Reception.GetIndianMenu();

            Console.WriteLine("\nGetting Italian Menu:");
            Reception.GetItalianMenu();

            Console.WriteLine("\nGetting Chinese Menu:");
            Reception.GetChineseMenu();
        }
    }
}