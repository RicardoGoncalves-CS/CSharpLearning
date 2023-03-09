﻿namespace SafariPark.App
{
    public class Vehicle
    {
        private int _capacity;
        private int _numPassengers;

        public int NumPassengers
        {
            get
            {
                return _numPassengers;
            }
            set
            {
                if (value > _capacity || value < 0)
                {
                    throw new ArgumentException();
                }
                _numPassengers = value;
            } 
        }
        public int Position { get; set; }
        public int Speed { get; init; }

        public Vehicle()
        {
        }

        public Vehicle(int capacity, int speed = 10)
        {
            this._capacity = capacity;
            this.Speed = speed;
        }

        public virtual string Move()
        {
            Position += Speed;
            return "Moving along";
        }

        public virtual string Move(int times)
        {
            Position = times * 10;
            return $"Moving along {times} times";
        }
    }
}