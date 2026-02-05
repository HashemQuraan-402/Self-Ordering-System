using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Self_Ordering_System_Project
{
    internal class Item
    {
        private string _name;
        private Image _itemImage;
        private double _price;
        private int _quantity;
        


        public string Name { get; set; }
        public Image ItemImage { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }


    }
}
