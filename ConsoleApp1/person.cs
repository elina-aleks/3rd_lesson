using System;


namespace ConsoleApp1
{

    public class Person
    {

        public string Whatis_name()
        {
            string whatis_name = "Ievadiet savu vardu:";
            return whatis_name;
        }
        public string Whatis_surname()
        {
            string whatis_surname = "Ievadiet savu uzvārdu:";
            return whatis_surname;
        }
        public string Whatis_date()
        {
            string whatis_date = "Ievadiet savu dzimšanas gadu:";
            return whatis_date;
        }
        public string Whatis_hobby()
        {
            string whatis_hobby = "Ievadiet savu hobiju:";
            return whatis_hobby;
        }
        public string Whatis_gender()
        {
            string whatis_weight = "Ievadiet savu dzimumu:";
            return whatis_weight;
        }


        public Person(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
        public string Surname { get; set; }
       // public string Date { get; set; }
        public string Hobby { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }



        public string GetGreeting()
        {
            string greeting = "Hello, my name is" + " " + Name + " " + Surname + ", " + " in the year of 2021 I will turn" + " " + Age + " " + "years old.";
            return greeting;

        }

    }
}
