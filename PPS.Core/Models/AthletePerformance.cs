using System;
using System.ComponentModel.DataAnnotations;

namespace PPS.Core.Models
{
    public enum PerformanceType {Game, Friendly, Training}
    public enum Attendance{Attended, Missed, Injury, Other}
    public enum Rating {Na, Poor, Average, Good, VeryGood, Excellent, AllStar}

    //Class repersenting a table in our database
    public class AthletePerformance
    {     

        //primary key
        public int Id { get; set; }

        public PerformanceType Type { get; set; }

        public Attendance Attendance {get; set; }

        public string Comments {get; set; }
        
        public int RedCardsReceived {get; set; }

        public int YellowCardsReceived {get; set; }
        public int TurnversFor {get; set; }
        public int TurnoversAgainst {get; set; }

        public int FoulsCommitted {get; set; }

        public Rating Rating {get; set; }

        //Foreign Key
        public int AthleteId {get; set; }
        //Navigation Properties
        public Athlete Athlete {get; set; }
    }
}