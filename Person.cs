using System;
using ConsoleApp1.Validators;
    
namespace ConsoleApp1
{
    class Person
    {
        public int Height { get; private set; }

        public int Weight { get; private set; }

        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public DateTime BirthDay { get; }

        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }

        public int Age
        {
            get
            {
                return (DateTime.Now - BirthDay).Days / 365;
            }
        }

        public bool ChangeHeight(int Height)
        {
            bool flag = IntValidator.Validate(Height);
            if (flag)
                this.Height = Height;
            return flag;
        }
        public Person(int height, int weight, string firstName, string lastName, DateTime birthDay)
        {
            Height = height;
            Weight = weight;
            FirstName = firstName;
            LastName = lastName;
            BirthDay = birthDay;
        }
    }
}
