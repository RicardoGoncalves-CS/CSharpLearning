using System.ComponentModel.DataAnnotations;

namespace SpartaTodo.App.Models.ViewModels
{
    public class CreateTodoVM
    {
        [Required(ErrorMessage = "Title is Required")]
        [StringLength(50)]
        public string Title { get; set; } = null!;

        public string? Description { get; set; }

        [Display(Name = "Complete?")]
        public bool Complete { get; set; }
    }
}
