using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndStructs
{
    public class Vehicle
    {
        protected int _capacity;
        private int _numPassengers;
        public int NumPassengers { get; set; } = 0;
        public int Position { get; private set; } = 0;
        public int Speed { get; set; } = 0;

        public virtual string Move()
        {
            Position += Speed;
            return "Moving along";
        }
        public virtual string Move(int times) //virtual allows derived classes to override them
        {
            Position += (Speed * times);
            return $"Moving along {times} times";
        }   
         
        public Vehicle(int capacity, int speed = 10)
        {
            Position = speed;
        } 

        public Vehicle()
        {
            //Position = 20;
        }
    }
}
