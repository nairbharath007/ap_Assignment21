using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryLibrary.Model
{
    internal class TeslaSedan : ITesla
    {
        public void Start()
        {
            Console.WriteLine("Tesla Sedan Starting.");
        }

        public void Stop()
        {
            Console.WriteLine("Tesla Sedan Stopping.");
        }
    }
}
