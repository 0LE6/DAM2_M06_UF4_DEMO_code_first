using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAM2_M06_UF4_DEMO_code_first.Model
{
    public class Profesor
    {
        public Profesor()
        {
            Cursos = new HashSet<Curso>();
        }

        [Key]
        public int ProfesorId { get; set; }

        public string Nombre { get; set; }

        // public string Ciudad { get; set; }

        // public int ProfesorId { get; set; }

        // Entity Frmework Core

        public ICollection<Curso> Cursos { get; set; }
    }
}
