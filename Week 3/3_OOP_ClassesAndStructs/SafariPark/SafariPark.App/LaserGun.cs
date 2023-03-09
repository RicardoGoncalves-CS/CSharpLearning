namespace SafariPark.App
{
    public class LaserGun : Weapon
    {
        public LaserGun(string brand) : base(brand)
        {
        }

        public override string Shoot()
        {
            return $"Zing!! {base.Shoot()}";
        }
    }
}