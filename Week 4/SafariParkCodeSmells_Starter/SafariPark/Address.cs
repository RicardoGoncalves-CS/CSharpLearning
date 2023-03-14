using System.Net;

namespace ClassesApp;

public class Address
{
    public int HouseNo { get; set; }
    public string Street { get; set; }
    public string Town { get; set; }

    public Address(int hNo, string street, string town)
    {
        HouseNo = hNo;
        Street = street;
        Town = town;
    }

    public string GetAddress()
    {
        return $"{HouseNo} {Street}, {Town}";
    }
}
