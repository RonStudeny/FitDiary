using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitDiary.Models;

public class SessionModel
{
    public string SessionName { get; set; }

    public List<ExerciseModel> Exercises { get; set; } = new List<ExerciseModel>();

    public override string ToString()
    {
        return $"{SessionName}";
    }
}
