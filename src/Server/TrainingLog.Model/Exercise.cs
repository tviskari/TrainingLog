using System;
using System.Collections.Generic;

namespace TrainingLog.Model
{
    public class Exercise
    {
        public int ID;

        public TimeSpan LengthInTime;
        public DateTime StartTime;
        public DateTime EndTime;

        public double LentghInMeters;
        public string Name;
        public string Comment;
        public string Type;
    }
}