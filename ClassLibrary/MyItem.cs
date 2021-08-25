using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class MyItem
    {
        public string Item { get; set; }
        public override string ToString()
        {
            return Item;
        }
    }
}
