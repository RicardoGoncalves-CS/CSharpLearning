namespace SafariPark.App
{
    public abstract class Weapon : IShootable
    {
        private string _brand;

        public Weapon(string brand)
        {
            _brand = brand;
        }

        public virtual string Shoot()
        {
            return $"{_brand}";
        }

        public override string ToString()
        {
            return $"{_brand}";
        }
    }
}