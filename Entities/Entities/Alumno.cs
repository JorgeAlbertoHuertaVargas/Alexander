using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace ENTIDADES.Entities
{
    public class Alumno
    {

        [Key]
        public int IdAlumno { get; set; }
        public string Codigo { get; set; }
        [Required]
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Genero { get; set; }
        public string Correo { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Nacimiento { get; set; }
        
        public int IdApoderados { get; set; }

    }
}
