﻿namespace GradingSystem.Models
{
    public class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Hours { get; set; }
        public Teacher Teacher { get; set; }
    }
}
