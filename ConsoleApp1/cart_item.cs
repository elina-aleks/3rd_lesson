using System;

namespace ConsoleApp1
{


    public class Cart_item
    {

        public string Whatis_lenght()
        {
            string whatis_lenght = "Ievadiet preces garumu:";
            return whatis_lenght;
        }
        public string Whatis_width()
        {
            string whatis_width = "Ievadiet preces platumu:";
            return whatis_width;
        }
        public string Whatis_weight()
        {
            string whatis_weight = "Ievadiet preces svaru:";
            return whatis_weight;
        }



        public Cart_item(string item)
        {
            Item = item;
        }
        public string Item { get; set; }
        public string Lenght { get; set; }
        public string Width { get; set; }
        public string Weight { get; set; }

        /*
        private int _weight;
        public int Weight
        {
            get
            {
                return _weight;
            }
            set
            {
                _weight = Math.Abs(value);
            }

        }
        */

        public string GetGreeting3()
        {
            string greeting3 = "Preces garums ir" + " " + Lenght + ", " + "platums ir" + " " + Width + ", " + "svars ir" + " " + Weight + ".";
            return greeting3;
        }
    } 

}