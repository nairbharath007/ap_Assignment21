using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeLibrary.Models
{
    internal class ItalianMenu : IMenu
    {
        public void DisplayMenu()
        {
            Console.WriteLine("Italian Menu: ");
            Console.WriteLine("1. Pasta \n2.Pizza \n3. Spagetti " +
                "\n4.Macarooni");
        }
    }
}
