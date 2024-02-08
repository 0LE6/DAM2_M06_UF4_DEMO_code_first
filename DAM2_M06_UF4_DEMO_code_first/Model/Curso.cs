using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAM2_M06_UF4_DEMO_code_first.Model
{
    public class Curso
    {
        public Curso()
        {
            Alumnos = new HashSet<Alumno>();
        }

        [Key]
        public int CursoId { get; set; }

        public string Nombre { get; set; }

        public string Ciudad { get; set; }

        // public int ProfesorId { get; set; } lo hace solo, no hace falta cuando haces el migrate

        // Entity Frmework Core

        public Profesor Profesor { get; set; }

        public ICollection<Alumno> Alumnos { get; set; }


    }
}
