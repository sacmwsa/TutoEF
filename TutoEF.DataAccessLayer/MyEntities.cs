using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TutoEF.DataAccessLayer.Entity;

namespace TutoEF.DataAccessLayer
{
    public class MyEntities : DbContext
    {
        public DbSet<Personne> Personnes { get; set; }
        /// <summary>
        /// Param de connection by default
        /// </summary>
        public MyEntities() : base("DefaultConnection")
        {

        }
    }
}
