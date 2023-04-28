using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariParkApp
{
    public class Person : IMovable, IEquatable<Person?>, IComparable<Person>
    {
        public int CompareTo(Person? other)
        {
            if (other == null) return 1;
            if (LastName != other.LastName)
            {
                return LastName.CompareTo(other.LastName);
            }
            else if(FirstName != other.FirstName)
            {
                return FirstName.CompareTo(other.FirstName);
            }
            else { return Age.CompareTo(other.Age); }
        }
        public string FirstName { get; init; } = "";
        public string LastName { get; init; } = "";
        private int _age;
        public int Age 
        {
            get { return _age; }
            set
            {
                if (value < 0 || value > 1000)
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


        //instead of comparing memory, extract all variables from the object and compare them individually 
        public override bool Equals(object? obj)
        {
            return Equals(obj as Person);
        }

        public bool Equals(Person? other)
        {
            return other is not null &&
                   FirstName == other.FirstName &&
                   LastName == other.LastName &&
                   _age == other._age &&
                   Age == other.Age &&
                   FullName == other.FullName;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(FirstName, LastName, _age, Age, FullName);
        }


        // updating the == and != operators to work how we want it to
        public static bool operator == (Person left, Person right)
        {
            return EqualityComparer<Person>.Default.Equals(left, right);
        }

        public static bool operator != (Person left, Person right)
        {
            return !(left == right);
        }
    }
}
