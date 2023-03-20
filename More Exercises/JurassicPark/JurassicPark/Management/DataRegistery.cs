using JurassicPark.People.Employees;
using JurassicPark.People.Visitors;

namespace JurassicPark.Management;

internal static class DataRegistery
{
    internal static Dictionary<string, List<string>> menuOptions = new Dictionary<string, List<string>>
    { 
        { "Main menu", new List<string> { 
            "Register new employee", 
            "Register new visitor", 
            "Quit" } },

        { "Register new employee", new List<string> { 
            "Register new scientist", 
            "Main menu" } },

        { "Register new visitor", new List<string> {
            "Register new scientist",
            "Main menu" } }
    };

    internal static List<Scientist> scientistsList = new List<Scientist>();
}