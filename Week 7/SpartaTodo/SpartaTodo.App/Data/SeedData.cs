using SpartaTodo.App.Models;

namespace SpartaTodo.App.Data;

public class SeedData
{
    public static void Initialise(IServiceProvider serviceProvider)
    {
        var context = serviceProvider.GetRequiredService<SpartaTodoContext>();



        if (context.TodoItems.Any())
        {
            context.TodoItems.RemoveRange(context.TodoItems);
            context.SaveChanges();
        }



        context.TodoItems.AddRange(
        new Todo
        {
            Title = "Complete survey",
            Description = "Complete the weekly survey",
            Complete = false,
            DateCreated = new DateTime(2023, 01, 03)
        },
        new Todo
        {
            Title = "Timecards",
            Description = "Complete timecard for this week",
            Complete = true,
            DateCreated = new DateTime(2023, 01, 05)
        },
        new Todo
        {
            Title = "Friday stand-up",
            Description = "Do the academy stand-up on Friday",
            Complete = false,
            DateCreated = new DateTime(2023, 01, 03)
        }
        );
        context.SaveChanges();
    }
}
