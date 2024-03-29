﻿namespace SafariPark.App
{
    public class Airplane : Vehicle
    {
        private string _airline;

        public int Altitude { get; private set; }

        public Airplane(int capacity) : base(capacity)
        {
        }

        public Airplane(int capacity, int speed, string airline = "") : base(capacity, speed)
        {
            _airline = airline;
        }

        public void Ascend(int distance)
        {
            Altitude += distance;
        }

        public void Descend(int distance)
        {
            Altitude -= distance;
        }

        public override string Move()
        {
            Distance += 1;
            return $"Moving along at an altitude of {Altitude} metres";
        }

        public override string Move(int times)
        {
            Distance += 1;
            return $"Moving along {times} times at an altitude of {Altitude} metres";
        }

        public override string ToString()
        {
            return $"Thank you for flying {_airline}: {GetType()} altitude: {Altitude}";
        }
    }
}
