using System;

namespace ConsoleApp1
{

    /// 1. uzdevums
    /// 

    class Telefons
    {
        // private static void Main(string[] args)
        private static void SetPhone(string[] args)
        {
            Phone phone = new Phone("Telefons");

            phone.Brand = "Blackberry";
            phone.Type = "Dual Sim";
            phone.Size = 14.7;

            string greeting = phone.GetGreeting();
            Console.WriteLine(greeting);

            string call = phone.Call();
            //  Console.WriteLine(call);

            string text = phone.Text();
            // Console.WriteLine(text);
        }
    }

    /// 2. uzdevums
    /// 

    class Mašīna
    {
        static void Main(string[] args)
        {
            Car car = new Car("Mašīna");

            car.Brand = "Reliant Robin";
            car.Plate = "AB-1234";
            car.Speed = 135;

            string greeting2 = car.GetGreeting2();
            Console.WriteLine(greeting2);

            string drive = car.Drive();
            Console.WriteLine(drive);

        }
    }
}
