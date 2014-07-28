using ManCave.Web.Adapter;
using ManCave.Web.Adapter.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ManCave.Web.Controllers
{
    public class apiTeamsController : ApiController
    {
        private IInterestsInterface _adapter;
        public apiTeamsController() 
        {
            _adapter = new InterestsAdapter();
        }
      
        [HttpGet]
        public IHttpActionResult Get(int id = -1)  //if no id is provided use -1
        {
            if (id == -1)
            {
                return Ok(_adapter.GetTeams());
            }
            else
            {
                return Ok(_adapter.GetTeam(id));
            }
        }

        //[HttpPost]


    }
}
