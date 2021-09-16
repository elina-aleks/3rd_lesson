using System;


namespace ConsoleApp1
{


    public class Phone
    {
        public Phone(string brand)
        {
            Brand = brand;
        }
        public string Brand { get; set; }
        public string Type { get; set; }
        public double Size { get; set; }

        public string Call()
        {
            string call = "Telefons var zvanīt.";
            return call;
        }

        public string Text()
        {
            string text = "Telefons lietot SMS.";
            return text;
        }

        public string GetGreeting()
        {
            string greeting = "Telefona marka ir" + " " + Brand + " " + "un teleforna modelis ir" + " " + Type + " " + "telefona izmers ir" + " " + Size + " " + "cm.";
            return greeting;

        }

    }
}
