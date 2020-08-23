using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Diplomado_MVC_Validar_Estudiante.Models
{
    public class Estudiante
    {
        [Required(ErrorMessage ="El Nombre es Obligatorio")]
        [MinLength(3,ErrorMessage ="El Nombre del Estudiante debe Tener al Menos 3 Caracteres")]
        public String Nombres {get;set;}

        [Required(ErrorMessage ="El Apello es Obligatorio")]
        [MinLength(3, ErrorMessage = "El Apellidoe del Estudiante debe Tener al Menos 3 Caracteres")]
        public string Apellidos { get; set; }

        [Range(14,65,ErrorMessage ="La Edad del Estudiante debe Estar entre 14 y 65 Años")]
        public int Edad { get; set; }

        [EmailAddress(ErrorMessage ="Debe Ingresar un Mail Válido")]
        public string Email { get; set; }

        [RegularExpression("[MmFf]",ErrorMessage ="Solo Puede Ingresar M=Masculino,F=Femenino")]
        public string Genero { get; set; }

        [RegularExpression("[CcSsUuDd]", ErrorMessage = "Solo Puede Ingresar C=Casado, S=Soltero, U=Union Libre, D=Divorciado")]
        public string EstadoCivil { get; set; }
    }
}