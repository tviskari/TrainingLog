using System;
using System.Collections.Generic;
using System.Text;
using TrainingLog.Model;

namespace TrainingLog.Repository.Interface
{
    public interface IExerciseRepository
    {
        List<Exercise> GetExcercises();

    }
}
