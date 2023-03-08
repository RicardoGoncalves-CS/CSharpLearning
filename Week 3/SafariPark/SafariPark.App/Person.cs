namespace SafariPark.App
{
    public class Person
    {
        // Fields
        // readonly makes that field immutable
        // private readonly string FirstName = "";
        // private string LastName = "";
        private int _age;

        // Properties
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
    }
}
