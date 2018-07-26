using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp11
{
    public enum Shops
    {
        Mango,
        PullBear,
        Bershka,
        NWY
    }
   public class Shop
    {
        public string ShopName { get; set; }
        public string ShopAdress { get; set; }
        public Bonus bonustype { get; set; }
    }
}
