using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyTrainees.Models
{
    public partial class Trainee
    {
        public override string ToString()
        {
            return $"{TraineeId}, {Name}, {Course}, {Location}";
        }
    }
}
