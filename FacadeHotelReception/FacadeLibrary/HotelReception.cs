using FacadeLibrary.Models;

namespace FacadeLibrary
{
    public class HotelReception
    {
        public void GetIndianMenu()
        {
            IHotel IndianHotel = new IndianHotel();
            IMenu Menu = IndianHotel.GetMenu();
            Menu.DisplayMenu();
        }

        public void GetItalianMenu()
        {
            IHotel ItalianHotel = new ItalianHotel();
            IMenu Menu = ItalianHotel.GetMenu();
            Menu.DisplayMenu();
        }

        public void GetChineseMenu()
        {
            IHotel ChineseHotel = new ChineseHotel();
            IMenu Menu = ChineseHotel.GetMenu();
            Menu.DisplayMenu();
        }
    }
}