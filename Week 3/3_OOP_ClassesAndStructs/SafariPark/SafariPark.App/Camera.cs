namespace SafariPark.App
{
    public class Camera : IShootable
    {
        private string _brand;

        public Camera(string brand)
        {
            _brand = brand;
        }

        public string Shoot()
        {
            return $"Taken a photo with the {_brand} camera";
        }

        public override string ToString()
        {
            return $"{_brand}";
        }
    }
}
