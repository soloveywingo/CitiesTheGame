using CitiesTheGame.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CitiesTheGame.Data_Access_Layer
{
    public class EntityRepository : IRepository<string>
    {
        EntityCitiesContext entityCitiesContext = new EntityCitiesContext();
        
        public IEnumerable<string> GetAll()
        {
            return entityCitiesContext.Cities.ToList();
        }
    }
}