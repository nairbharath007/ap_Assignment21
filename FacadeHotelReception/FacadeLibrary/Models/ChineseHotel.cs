using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeLibrary.Models
{
    internal class ChineseHotel : IHotel
    {
        public IMenu GetMenu()
        {
            return new ChineseMenu();
        }
    }
}
