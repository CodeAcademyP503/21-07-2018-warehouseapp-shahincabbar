using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp11
{

   public enum Bonus
    {
        percent,
        cash
    }

   public class Grade
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public Bonus Bonus { get; set; }
    }
}
