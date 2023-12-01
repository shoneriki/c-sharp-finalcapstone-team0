﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Capstone.Models
{
    public class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Breed { get; set; }
        public string Species { get; set; }
        public bool MedicalNeeds { get; set; }
        public string Color { get; set; }
        public bool IsAdopted { get; set; }
        public string OwnerName { get; set; }
        public string Sex { get; set; }
        public int Weight { get; set; }
        public string AboutMe { get; set; }
        public List<string> PhotoPaths { get; set; }
        public bool IsGood { get; set; }
    }
}