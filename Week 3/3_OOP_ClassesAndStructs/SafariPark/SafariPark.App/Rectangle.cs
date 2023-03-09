namespace SafariPark.App
{
    public sealed class Rectangle : Shape
    {
        private int _width;
        private int _height;

        public Rectangle(int width, int height)
        {
            _width = width;
            _height = height;
        }

        public override int CalculateArea()
        {
            return _width * _height;
        }

        public override string ToString()
        {
            return $"{CalculateArea()}";
        }
    }
}