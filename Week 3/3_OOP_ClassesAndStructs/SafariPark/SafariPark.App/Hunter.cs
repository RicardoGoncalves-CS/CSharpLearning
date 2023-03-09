namespace SafariPark.App
{
    public class Hunter : Person, IShootable
    {
        public IShootable Shooter { get; set; }

        public Hunter()
        {
        }

        public Hunter(string fName, string lName, IShootable shooter) : base(fName, lName)
        {
            Shooter = shooter;
        }

        public string Shoot()
        {

            if (Shooter is Camera) return $"{FullName} has taken a photo with their {Shooter}";
            else if (Shooter is WaterPistol) return $"{FullName} shot a menacing string of water with their {Shooter}";
            else if (Shooter is LaserGun) return $"{FullName} shot a ray of burning happiness with their {Shooter}";
            else return $"{FullName} is not equipped with any shootable";
        }

        public override string ToString()
        {
            return $"{base.ToString()} Camera: {Shooter.ToString}";
        }
    }
}
