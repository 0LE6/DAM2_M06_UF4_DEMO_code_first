using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAM2_M06_UF4_DEMO_code_first.Model
{
    public class SchoolDbContext : DbContext
    {
        public SchoolDbContext() { }

        public SchoolDbContext(DbContextOptions options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("Server=localhost;Database=SCHOOL;Uid=root;Pwd=\"\"");
            }
        }

        public virtual DbSet<Alumno> Alumnos { get; set; }

        public virtual DbSet<Curso> Cursos { get; set; }

        public virtual DbSet<Profesor> Profesor { get; set; }
    }
}
