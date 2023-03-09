namespace SafariPark.App
{
    public class Airplane : Vehicle
    {
        private string _airline;

        public int Altitude { get; private set; } = 0;

        public Airplane(int capacity) : base(capacity)
        {
        }

        public Airplane(int capacity, int numPassengers, string airline = "") : base(capacity, numPassengers)
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
            return $"Moving along at an altitude of {Altitude} metres.";
        }

        public override string Move(int times)
        {
            return $"Moving along {times} times at an altitude of {Altitude} metres.";
        }

        public override string ToString()
        {
            return $"Thank you for flying {_airline}: {GetType()} altitude: {Altitude}";
        }
    }
}
