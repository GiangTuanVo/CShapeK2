using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary_Test
{
    public class Product
    {
        public string Name;
        public string Size;
        public Color Color;

        public Product()
        {
        }

        public Product(string name, string size, Color color)
        {
            Name = name;
            Size = size;
            Color = color;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
