﻿using System.ComponentModel.DataAnnotations;

namespace SpartaTodo.App.Models;

public class Todo
{
    public int Id { get; set; }


    [Required(ErrorMessage = "Title is Required")]
    [StringLength(50)]
    public string Title { get; set; } = null!;


    public string? Description { get; set; }


    [Display(Name = "Complete?")]
    public bool Complete { get; set; }


    [DataType(DataType.Date)]
    [Display(Name = "Created")]
    public DateTime DateCreated { get; init; } = DateTime.Now;
}
