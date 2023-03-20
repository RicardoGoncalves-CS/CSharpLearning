using System;
using System.Collections.Generic;

namespace AcademyTrainees.Models;

public partial class Trainee
{
    public int TraineeId { get; set; }

    public string? Name { get; set; }

    public string? Course { get; set; }

    public string? Location { get; set; }
}
