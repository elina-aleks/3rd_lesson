using System;

namespace ConsoleApp1
/*
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Ellie");

            Person person2 = person;

            // person.Name = "Ellie";
            person.Age = 100;
            person.IsMale = false;
            person.Money = 154.58;
            person.Initial = 'A';

            person2.Age = 26;

            string greeting = person.GetGreeting();
            Console.WriteLine(greeting);
        }
    }
}
*/

{
    class Program
    {
        static void Main(string[] args)
        {
            Phone phone = new Phone("Telefons");

            phone.Brand = "Blackberry";
            phone.Type = "Dual Sim";
            phone.Size = 14.7;
            phone.Call = true;
            phone.Text = true;

            string greeting = phone.GetGreeting();
            Console.WriteLine(greeting);

            string call = phone.Call();
            Console.WriteLine(call);

            string text = phone.Text();
            Console.WriteLine(text);
        }
    }
}