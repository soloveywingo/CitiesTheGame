using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CitiesTheGame.Models
{
    public static class Cities
    {
        public static HashSet<string> cities = new HashSet<string>();
        public static Dictionary<char[],string> citiesThatWere = new Dictionary<char[], string>();
        public static char StartLetter;

        static Cities()
        {
            FillCitiesInto();
        }
        static void FillCitiesInto()
        {
            for(int i = 0; i < DataBaseConnector.dataRows.Length ; i++)
            {
                string name = DataBaseConnector.dataRows[i].ItemArray.GetValue(1).ToString();
                cities.Add(name.ToUpper().Trim());
            }
        }

        
    }
}