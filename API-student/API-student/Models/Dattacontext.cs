using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace API_student.Models
{
    public class Dattacontext : DbContext
    {
        public Dattacontext(): base("DefaultConnection") //constructor
        {
        }

        public System.Data.Entity.DbSet<API_student.Models.Student> Students { get; set; }
    }
}