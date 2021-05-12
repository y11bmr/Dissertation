using System;
using System.Text;
using System.Collections.Generic;

using PPS.Core.Models;

namespace PPS.Data.Services
{
    public static class Seeder
    {
        // use this class to seed the database with dummy 
        // test data using an IUserService 
         public static void Users(IUserService svc)
        {
            svc.Initialise();

            // add users
            svc.AddUser("Manager", "man@mail.com", "manager", Role.Manager);
            svc.AddUser("Strength And Conditioning Coach", "man@mail.com", "s&c coach", Role.StrengthandConditioningCoach);
            svc.AddUser("Physio", "physio@mail.com", "physio", Role.Physio);
            svc.AddUser("Athlete", "athlete@mail.com", "athlete", Role.Athlete);    
            svc.AddUser("Administrator", "man@mail.com", "administrator", Role.Administrator);

        }

         public static void Athletes(IAthleteService svc)
        {
            svc.Initialise();
        }
    }
}