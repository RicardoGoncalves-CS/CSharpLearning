using Microsoft.AspNetCore.Identity;

namespace SpartaTodo.App.Models
{
    public class Spartan : IdentityUser
    {
        public List<Todo>? TodoItems { get; set; }
    }
}
