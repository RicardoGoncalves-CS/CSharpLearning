using System.ComponentModel.DataAnnotations;

namespace SpartaTodo.App.Models.ViewModels
{
    public class MarkCompleteVM
    {
        public int Id { get; set; }
        public bool Complete { get; set; }
    }
}
