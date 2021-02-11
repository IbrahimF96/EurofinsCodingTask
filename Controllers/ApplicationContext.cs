using EurofinsCodingTask.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EurofinsCodingTask.Controllers
{
    public class ApplicationContext : DbContext
    {
        public DbSet<UserInput> Inputs { get; set; }

    }
}