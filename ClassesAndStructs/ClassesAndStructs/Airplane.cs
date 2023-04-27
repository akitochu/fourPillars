using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndStructs
{
    public class Airplane : Vehicle
    {
        private string _airline;
        public int Altitude { get; private set; } = 0;
        

        public Airplane(int capacity, int speed, string airline)
        {
            _capacity = capacity;
            Speed = speed;
            _airline = airline;
        }

        public Airplane(int capacity)
        {
            _capacity = capacity;
        }

        public void Ascend(int distance)
        {
            Altitude += distance;
        }
        public void Descend(int distance)
        {
            Altitude -= distance;
            if(Altitude < 0)
            {
                throw new OverflowException("Cannot fly below ground level");
            }
        }
        public override string Move()
        {
            base.Move();
            return $"Moving along at an altitude of {this.Altitude} metres.";
        }
        public override string Move(int times)
        {
            base.Move(times);
            return $"Moving along {times} times at an altitude of {this.Altitude} metres."; 
        }

        public override string ToString()
        {
            return $"Thank you for flying {_airline}: {base.ToString()} capacity: {_capacity} passengers: {NumPassengers} speed: {Speed} position: {Position} altitude: {Altitude}.";
        }
    }
}
