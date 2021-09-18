using System;

namespace ConsoleApp1
{

    /// 1. uzdevums
    /// 

    class Telefons
    {
        // private static void Main(string[] args)
        public static void SetPhone(string[] args)
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
        public static void SetCar(string[] args)
        {
            Car car = new Car("Mašīna");

            car.Brand = "Reliant Robin";
            car.Plate = "AB-1234";
            car.Speed = 135;

            string greeting2 = car.GetGreeting2();
            Console.WriteLine(greeting2);

            string drive = car.Drive();
            Console.WriteLine(drive);

            string accelerate = car.Accelerate();
            Console.WriteLine(accelerate);

            string brake = car.Brake();
            Console.WriteLine(brake);

            string honk = car.Honk();
            Console.WriteLine(honk);

        }
    }


    /// 3. uzdevums
    /// 

    class Prece
    {
        public static void SetPrece(string[] args)
        {
            Cart_item cart_item = new Cart_item("Prece");

            string whatis_lenght = cart_item.Whatis_lenght();
            Console.WriteLine(whatis_lenght);
            string Lenght = Console.ReadLine();

            string whatis_width = cart_item.Whatis_width();
            Console.WriteLine(whatis_width);
            string Width = Console.ReadLine();

            string whatis_weight = cart_item.Whatis_weight();
            Console.WriteLine(whatis_weight);
            string Weight = Console.ReadLine();

            cart_item.Lenght = Lenght;
            cart_item.Width = Width;
            cart_item.Weight = Weight;

            string greeting3 = cart_item.GetGreeting3();
            Console.WriteLine(greeting3);





        }
    }


    /// 4. uzdevums
    /// 
    class Persona
    {
        public static void Main(string[] args)
        {
            Person person = new Person("Person");

            string whatis_name = person.Whatis_name();
            Console.WriteLine(whatis_name);
            string Name = Console.ReadLine();

            string whatis_surname = person.Whatis_surname();
            Console.WriteLine(whatis_surname);
            string Surname = Console.ReadLine();

            string whatis_date = person.Whatis_date();
            Console.WriteLine(whatis_date);
            string Date = Console.ReadLine();

            string whatis_hobby = person.Whatis_hobby();
            Console.WriteLine(whatis_hobby);
            string Hobby = Console.ReadLine();

            string whatis_gender = person.Whatis_gender();
            Console.WriteLine(whatis_gender);
            string Gender = Console.ReadLine();


            int birthyear = int.Parse(Date);
            person.Age = 2021 - birthyear;


            person.Name = Name;
            person.Surname = Surname;
            // person.Date = "";
            person.Hobby = Hobby;
            person.Gender = Gender;

            string greeting = person.GetGreeting();
            Console.WriteLine(greeting);

        }
    }
}

