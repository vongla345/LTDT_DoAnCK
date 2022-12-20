using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    internal class Item
    {
        string name;    //Tên của món hàng
        string adress;  //Địa chỉ để giao

        public Item(string _name = "null", string _adress = "null")
        {
            name = _name;
            adress = _adress;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Adress
        {
            set { adress = value; }
            get { return adress; }
        }
    }
}
