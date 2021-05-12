using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;

namespace PPS.Core.Models
{      
    // Class repersenting a table in our database
    public class Athlete
    { 
      
        //primary key
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public double Age {get; set; }

        [Required]
        public string Position { get; set; }

        [Required]
        public double Height { get; set;}

        public double Weight {get; set; }

        [Required]
        public string Injured { get; set; }

        //navigation properties
        public ICollection <AthletePerformance> Performances { get; set; } = new List<AthletePerformance>();

        public ICollection <AthleteInjury> Injuries { get; set; } = new List<AthleteInjury>();


       // Used for printing Athletes to the console during testing
        public override string ToString()
        {
            return $"Id:{Id} Full Name:{Name} Athlete Age:{Age} Athlete Position: {Position} Height: {Height}: Injured {Injured}:";
        }

       }
    }