namespace SafariPark.App
{
    internal interface IMovable
    {
        int Distance { get; set; }

        string Move();

        string Move(int times);
    }
}