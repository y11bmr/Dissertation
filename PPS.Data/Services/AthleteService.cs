using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

using PPS.Core.Models;
using PPS.Core.Security;
using PPS.Data.Repositories;
namespace PPS.Data.Services
{
    public class AthleteService : IAthleteService
    {
        private readonly DatabaseContext  db;

        public AthleteService()
        {
            db = new DatabaseContext(); 
        }

        public void Initialise()
        {
           db.Initialise(); 
        }
         
         public Athlete AddAthlete(Athlete a)
        {
            //checking to see if another athlete already exists with the same name
            var exists = db.Athletes.FirstOrDefault (o => o.Name == a.Name);
            if (exists != null)
            {
                return null;
            }

            db.Athletes.Add(a);
            db.SaveChanges();
            return a; //returns newly added athlete
        }

        public Athlete GetAthleteById(int id)
        {
            return db.Athletes.Include(a => a.Injuries )
                                .Include(a => a.Performances)
                                .FirstOrDefault(a => a.Id == id);
        }

        public IList<Athlete> GetAthletes()
        {
            return db.Athletes.ToList();
        }

        public bool DeleteAthlete(int id)
        {
            var a = GetAthleteById(id);
            if (a == null)
            {
                return false;
            }
            db.Athletes.Remove(a);
            db.SaveChanges();
            return true;
        }
    

    }
}
