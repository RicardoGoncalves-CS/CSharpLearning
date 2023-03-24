namespace DecoratorPattern3
{
    internal class Audi : Car
    {

        protected string _description = "Base Audi A4";
        private decimal _price = 18000;
        private int _speed = 200;

        public Audi() { }

        public override decimal Price()
        {
            return _price;
        }

        public override int Speed()
        {
            return _speed;
        }

        public override string Description()
        {
            return _description;
        }
    }
}
