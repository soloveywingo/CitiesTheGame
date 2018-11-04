using CitiesTheGame.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CitiesTheGame.Data_Access_Layer
{
    public class AdoNetRepository : IRepository<string>
    {

        public IEnumerable<string> GetAll()
        {
            for (int i = 0; i < DataBaseConnector.dataRows.Length; i++)
            {
                string name = DataBaseConnector.dataRows[i].ItemArray.GetValue(1).ToString();
                yield return name.ToUpper().Trim();
            }
        }
    }
}