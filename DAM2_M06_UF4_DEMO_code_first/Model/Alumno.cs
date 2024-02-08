using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAM2_M06_UF4_DEMO_code_first.Model
{
    public class Alumno
    {
        [Key]
        public int AlumnoId { get; set; }
        public string Nombre { get; set; }
        public DateTime DataNacimiento { get; set; }
        public double NotaFinal { get; set; }
        public Curso Curso { get; set; }

    }
}
