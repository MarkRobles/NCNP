using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace NCNP.Models
{
    public class Pacientes
    {
       
        public Guid Id { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Usted debe especificar un Nombre")]
        [MinLength(2, ErrorMessage = "El tamaño minimo  es de 2 letras")]
        [MaxLength(40, ErrorMessage = "El tamaño maximo es de 50 letras")]
        public String Nombre { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Usted debe especificar un Apellido Paterno")]
        [MinLength(2, ErrorMessage = "El tamaño minimo  es de 2 letras")]
        [MaxLength(40, ErrorMessage = "El tamaño maximo es de 50 letras")]
        public String ApellidoPaterno { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Usted debe especificar un Apellido Materno")]
        [MinLength(2, ErrorMessage = "El tamaño minimo  es de 2 letras")]
        [MaxLength(40, ErrorMessage = "El tamaño maximo es de 50 letras")]
        public String ApellidoMaterno { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Usted debe especificar una fecha de nacimiento")]
        [DataType(DataType.DateTime)]
        public DateTime FechaNacimiento { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Usted debe especificar la edad")]
        public Byte Edad { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Usted debe especificar un genero")]
        [MinLength(2, ErrorMessage = "El tamaño minimo  es de 2 letras")]
        [MaxLength(40, ErrorMessage = "El tamaño maximo es de 30 letras")]
        public String Genero { get; set; }
        [MinLength(2, ErrorMessage = "El tamaño minimo  es de 2 letras")]
        [MaxLength(40, ErrorMessage = "El tamaño maximo es de 50 letras")]
        public String Escolaridad { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Usted debe especificar un Correo")]
        [DataType(DataType.EmailAddress)]
        public String Correo { get; set; }
        [MinLength(2, ErrorMessage = "El tamaño minimo  es de 2 letras")]
        [MaxLength(40, ErrorMessage = "El tamaño maximo es de 255 letras")]
        public String Calle { get; set; }
        public int NumeroExterior { get; set; }
        public int NumeroInterior { get; set; }
        [MinLength(2, ErrorMessage = "El tamaño minimo  es de 2 letras")]
        [MaxLength(40, ErrorMessage = "El tamaño maximo es de 255 letras")]
        public String Colonia { get; set; }
        [MinLength(2, ErrorMessage = "El tamaño minimo  es de 2 letras")]
        [MaxLength(40, ErrorMessage = "El tamaño maximo es de 255 letras")]
        public String Municipio { get; set; }
        [MinLength(2, ErrorMessage = "El tamaño minimo  es de 2 letras")]
        [MaxLength(40, ErrorMessage = "El tamaño maximo es de 255 letras")]
        public String Estado { get; set; }
        [StringLength(5, ErrorMessage = "El tamaño debse ser de 5 letras")]
        [DataType(DataType.PostalCode)]
        public String CodigoPostal { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Usted debe especificar un telefono")]
        [StringLength(10, ErrorMessage = "El tamaño debe ser de 5 letras")]
        [DataType(DataType.PhoneNumber)]
        public String Telefono { get; set; }
        [MinLength(2, ErrorMessage = "El tamaño minimo  es de 2 letras")]
        [MaxLength(50, ErrorMessage = "El tamaño maximo es de 50 letras")]
        public String Ocupacion { get; set; }
        [MinLength(2, ErrorMessage = "El tamaño minimo  es de 2 letras")]
        [MaxLength(255, ErrorMessage = "El tamaño maximo es de 255 letras")]
        public String HorarioLaboral { get; set; }
        public Byte Hijos { get; set; }
        public String Notas { get; set; }
        [MinLength(12, ErrorMessage = "El tamaño minimo  es de 12 letras")]
        [MaxLength(13, ErrorMessage = "El tamaño maximo es de 13 letras")]
        public String RFC { get; set; }



    }
}