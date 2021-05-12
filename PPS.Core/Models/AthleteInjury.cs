using System;
using System.ComponentModel.DataAnnotations;

namespace PPS.Core.Models
{

    //Class repersenting a table in our database
    public class AthleteInjury
    {     

        //primary key
        public int Id { get; set; }

        public string TypeOfInjury {get; set; }

        public double ProjectedTimeScaleOfInjury {get; set; }

        public string RecurringInjury {get; set; }

        public string PhysioReport { get; set; }

        public string RehabProgram { get; set; }

        public string MedicalHelp  {get; set; }
        
        //Foreign Key
        public int AthleteId {get; set; }

        //Navigation Properties
        public Athlete Athlete {get; set; }
    }
}