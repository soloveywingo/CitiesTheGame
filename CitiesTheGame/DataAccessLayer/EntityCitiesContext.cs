using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CitiesTheGame.Data_Access_Layer
{
    public class EntityCitiesContext : DbContext
    {
        public DbSet<string> Cities;
        public EntityCitiesContext() : base(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\VisualStudioProjects\CitiesTheGame\CitiesTheGame\App_Data\Database1.mdf;Integrated Security=True")
        {

        }
    }
}