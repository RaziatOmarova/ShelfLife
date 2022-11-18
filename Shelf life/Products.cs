using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shelf_life
{
    internal class Products
    {
        public Products(string name,int expirationdate, int time)
        {
            this.Name = name;
            this.Expirationdate = expirationdate;
            this.Time = time;
        }
        public string Name { get; set; }
        public int Expirationdate { get; set; }
        public int Time { get; set; }
    }
}
