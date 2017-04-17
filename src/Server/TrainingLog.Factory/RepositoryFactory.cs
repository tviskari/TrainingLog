using System;
using TrainingLog.Repository;
using TrainingLog.Repository.Interface;

namespace TrainingLog.Factory
{
    public class RepositoryFactory
    {
        public IExerciseRepository GetExerciseRepo()
        {
            return new ExerciseFakeRepository();
        }
    }
}
