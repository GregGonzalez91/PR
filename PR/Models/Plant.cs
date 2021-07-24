using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PR.Models
{
    public class Plant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
       
        public Color Color { get; set; }
        public int Rating { get; set; }
    }

    public class Color
    {     
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class PlantDbContext : DbContext
    {
        public DbSet<Plant> Plants { get; set; }
        public DbSet<Color> Color { get; set; }

    }
}