using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    class Items
    {
        public string name;
        float price;
        public string itemtype;
        

        public Items(string name, string itemtype, float price)
        {
            this.name = name;
            this.itemtype = itemtype;
            this.price = price;
        }

    }
}
