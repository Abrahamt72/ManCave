using ManCave.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManCave.Web.Adapter.Interfaces
{
    interface IInterestsInterface
    {
        Team GetTeam(int id);
        List <Team> GetTeams();
        Car GetCar(int id);
        List <Car> GetCars();
        Food GetFood(int id);
        List <Food> GetFoods();
       
        //Team GetTeam(int id);
        //List<Team> GetTeams();

        //list <UserInterestsVM> GetUserInterests();
        
    }
}
