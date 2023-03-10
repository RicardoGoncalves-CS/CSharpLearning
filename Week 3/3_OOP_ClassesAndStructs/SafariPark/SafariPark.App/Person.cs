namespace SafariPark.App
{
    public class Person : IMovable, IEquatable<Person?>, IComparable<Person?>
    {
        // Fields
        // readonly makes that field immutable
        // private readonly string FirstName = "";
        // private string LastName = "";
        private int _age;

        // Properties
        public int Distance { get; set; }
        public string FirstName { get; init; } = "";
        public string LastName { get; init; } = "";

        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value < 0)
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

        public Person(string firstName)
        {
            FirstName = firstName;
        }

        public Person()
        {
        }

        public string FullName => $"{FirstName } {LastName}";

        public override string ToString()
        {
            return $"{base.ToString()} Name: {FullName} Age: {Age}";
        }

        public string Move()
        {
            Distance += 1;
            return "Moving along";
        }

        public string Move(int times)
        {
            Distance += 1;
            return $"Moving along {times} times";
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as Person);
        }

        // Implemented during Object comparison lesson
        public bool Equals(Person? other)
        {
            return other is not null &&
                   _age == other._age &&
                   Distance == other.Distance &&
                   FirstName == other.FirstName &&
                   LastName == other.LastName &&
                   Age == other.Age &&
                   FullName == other.FullName;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(_age, Distance, FirstName, LastName, Age, FullName);
        }

        public int CompareTo(Person? other)
        {
            if (other == null) return 1;

            if (LastName != other.LastName)
            {
                return this.LastName.CompareTo(other.LastName);
            }
            else if (FirstName != other.FirstName)
            {
                return FirstName.CompareTo(other.FirstName);
            }
            else 
            {
                return Age.CompareTo(other.Age);
            } 
        }

        public static bool operator ==(Person? left, Person? right)
        {
            return EqualityComparer<Person>.Default.Equals(left, right);
        }

        public static bool operator !=(Person? left, Person? right)
        {
            return !(left == right);
        }
    }
}