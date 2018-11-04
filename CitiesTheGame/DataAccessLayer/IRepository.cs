using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CitiesTheGame.Data_Access_Layer
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetAll();
    }
}