using System;
namespace PPS.Core.Models
{
    // Users who will be using the web app
    public enum Role {Manager, StrengthandConditioningCoach, Physio, Athlete, Administrator }

    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        // User role within application
        public Role Role { get; set; }

        // used to store jwt auth token 
        public string Token { get; set; }
    }
}
