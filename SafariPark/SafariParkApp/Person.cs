using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariParkApp
{
    public class Person : IMovable
    {
        public string FirstName { get; init; } = "";
        public string LastName { get; init; } = "";
        private int _age;
        public int Age 
        {
            get { return _age; }
            set
            {
                if (value < 0 || value > 99)
                {
                    throw new ArgumentException();
                }
                _age = value;
            }
        }

        public Person(string firstName, string lastName, int age = 0)
        {
            FirstName = firstName;
            LastName = lastName; 
            Age = age;
        }
        
        public Person() { }

        public Person(string firstName)
        {
            FirstName = firstName;
        }

        //public string GetFullName()
        //{
        //    return $"{FirstName} {LastName}";
        //}

        public string FullName => $"{FirstName} {LastName}";

        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }

        public override string ToString()
        {
            return $"{base.ToString()} Name: {GetFullName()} Age : {Age}";
        }

        public virtual string Move(int numMoves)
        {
            return $"Moving along {numMoves} times";
        }

        public virtual string Move()
        {
            return "Moving along";
        }
    }
}
