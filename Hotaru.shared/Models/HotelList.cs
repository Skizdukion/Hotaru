using System;
using System.Collections.Generic;
using System.Text;

namespace Hotaru.shared.Models
{
    public class HotelList
    {
        public int numHotel { get; set; }
        public List<Hotel> hotellist = new List<Hotel>();
        public HotelList(int num)
        {
            numHotel = num;
            for (int i = 0; i <= num; i++)
            {
                Hotel temp = new Hotel();
                temp.name = "Hotel number " + i.ToString();
                temp.address = "empty";
                if (i%2==0) temp.imglink = "https://r-cf.bstatic.com/images/hotel/max1024x768/231/231141387.jpg";
                    else temp.imglink = "https://r-cf.bstatic.com/images/hotel/max1024x768/245/245801221.jpg";
                hotellist.Add(temp);
            }
        }
        public HotelList()
        {

        }
    }
}
