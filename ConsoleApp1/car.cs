using System;


namespace ConsoleApp1
{

    public class Car
    {
        public Car(string brand)
        {
            Brand = brand;
        }
        public string Brand { get; set; }
        public string Plate { get; set; }
        public int Speed { get; set; }

        public string Drive()
        {
            string drive = "Mašīna var braukt.";
            return drive;
        }

        public string Accelerate()
        {
            string accelerate = "Mašīna var paātrināt ātrumu.";
            return accelerate;
        }

        public string Brake()
        {
            string brake = "Mašīna var bremzēt.";
            return brake;
        }

        public string GetGreeting2()
        {
            string greeting2 = "Mašīnas marka ir" + " " + Brand + " " + ", mašīnas numurzīme ir" + " " + Plate + " " + "mašīnas ātrums ir" + " " + Speed + " " + "kilometri stundā.";
            return greeting2;

        }

        public string Honk()
        {
            string honk = "Beep-Beep.";
            return honk;
        }

    }
}
