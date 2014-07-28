using ManCave.Data;
using ManCave.Data.Models;
using ManCave.Web.Adapter.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ManCave.Web.Adapter
{
    public class InterestsAdapter : IInterestsInterface
    {
        public Team GetTeam(int id)
        {
            ApplicationDbContext Db = new ApplicationDbContext();
            Team Team = Db.Teams.Where(t => t.Id == id).FirstOrDefault();
            return Team;
        }

        public List<Team> GetTeams()
        {
            ApplicationDbContext Db = new ApplicationDbContext();
            List <Team> Teams = Db.Teams.ToList();
            return Teams;
        }

        public Car GetCar(int id)
        {
            ApplicationDbContext Db = new ApplicationDbContext();
            Car Car = Db.Cars.Where(c => c.Id == id).FirstOrDefault();
            return Car;
        }

        public List<Car> GetCars()
        {
            ApplicationDbContext Db = new ApplicationDbContext();
            List<Car> Cars = Db.Cars.ToList();
            return Cars;
        }

        public Food GetFood(int id)
        {
            ApplicationDbContext Db = new ApplicationDbContext();
            Food Food = Db.Foods.Where(f => f.Id == id).FirstOrDefault();
            return Food;
        }

        public List<Food> GetFoods()
        {
            ApplicationDbContext Db = new ApplicationDbContext();
            List<Food> Foods = Db.Foods.ToList();
            return Foods;
        }
    }
}