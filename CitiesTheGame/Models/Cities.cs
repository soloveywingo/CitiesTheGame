using CitiesTheGame.Data_Access_Layer;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CitiesTheGame.Models
{
    public static class Cities
    {
        public static IEnumerable<string> CitiesTable = new HashSet<string>();
        public static Dictionary<char[],string> CitiesThatWereUsed = new Dictionary<char[], string>();
        public static char StartLetter;

        static Cities()
        {
            AdoNetRepository adoNetRepository = new AdoNetRepository();
            EntityRepository entityRepository = new EntityRepository();
            CitiesTable = adoNetRepository.GetAll();
            //CitiesTable = entityRepository.GetAll();
        }

        
    }
}