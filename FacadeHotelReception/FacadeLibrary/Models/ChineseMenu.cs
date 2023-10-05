using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeLibrary.Models
{
    internal class ChineseMenu : IMenu
    {
        public void DisplayMenu()
        {
            Console.WriteLine("Chinese Menu");
            Console.WriteLine("1. Chinese Bhel \n2. Hakka Noodles \n3. Schezchuan Chutney " +
                "\n4. Gobi Manchurian");
        }
    }
}
