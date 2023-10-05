using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeLibrary.Models
{
    internal class IndianMenu : IMenu
    {
        public void DisplayMenu()
        {
            Console.WriteLine("Indian Menu:");
            Console.WriteLine("1. Paneer Angaara\n2. Mattar Panner \n3.Momos" +
                "\n4.Kofta");
        }
    }
}
