namespace SafariPark.App
{
    public class Hunter : Person
    {
        private string _camera;

        public Hunter(string fName, string lName, string camera = "") : base(fName, lName)
        {
            _camera = camera;
        }

        public string Shoot()
        {
            return $"{FullName} has taken a photo with their {_camera}";
        }
    }
}
