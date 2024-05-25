﻿using System.Data;

namespace Comics.Model
{
    public class SubjectGrade
    {
        public int Id { get; set; }
        public Subject Subject { get; set; }
        public int Grade { get; set; }
        public DateTime Date { get; set; }
    }
}
