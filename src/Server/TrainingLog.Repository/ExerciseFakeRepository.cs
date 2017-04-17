using System;
using System.Collections.Generic;
using System.Text;
using TrainingLog.Model;
using TrainingLog.Repository.Interface;

namespace TrainingLog.Repository
{
    public class ExerciseFakeRepository : IExerciseRepository
    {
        public List<Exercise> GetExcercises()
        {
            List<Exercise> listOfExcericises = new List<Exercise>();

            listOfExcericises.Add(new Exercise
            {
                ID = 0,
                Comment = "Kommenttikenttä. Vapaa teksti.",
                Name = "PK1"
            });

            listOfExcericises.Add(new Exercise
            {
                ID = 1,
                Comment = "Vapaata tekstiä.",
                Name = "VK1"
            });

            return listOfExcericises;
        }
    }
}
