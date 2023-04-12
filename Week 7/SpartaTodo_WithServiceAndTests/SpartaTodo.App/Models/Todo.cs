﻿using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace SpartaTodo.App.Models
{
    public class Todo
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Title is Required")]
        [StringLength(50)]
        public string Title { get; set; } = null!;

        public string? Description { get; set; } = "";

        [Display(Name = "Complete?")]
        public bool Complete { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Created")]
        public DateTime DateCreated { get; init; } = DateTime.Now;

        [ValidateNever]
        [ForeignKey("Spartan")]
        public string SpartanId { get; set; } = null!;

        public Spartan? Spartan { get; set; }
    }
}
