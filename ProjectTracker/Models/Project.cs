﻿namespace ProjectTracker.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Priority { get; set; }
        public string Status { get; set; }

        public Project()
        {

        }
    }
}
