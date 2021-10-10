using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ejercicio_Wirsolut.Models
{
    public class Cliente
    {
        public int ClienteID { get; set; }

        [Required(ErrorMessage = "El nombre es requerido")]
        [StringLength(30)]
        
        public string Name { get; set; }

        [Required(ErrorMessage = "El apellido es requerido")]
        [StringLength(30)]
        public string Surname { get; set; }

        [Required(ErrorMessage = "El email es requerido")]
        [StringLength(250)]
        public string Email { get; set; }

        [Required(ErrorMessage = "El DNI es requerido")]
        public int DNI { get; set; }

        [Required(ErrorMessage = "La fecha de nacimiento es requerida")]
        [Display(Name = "Date of birth")]
        [DataType(DataType.DateTime)]
        public DateTime DateOfBirth { get; set; }

        [Required(ErrorMessage = "La direccion es requerida")]
        [StringLength(250)]
        public string Direction { get; set; }

        [Required(ErrorMessage = "El codigo postal es requerido")]
        [Display(Name = "Postal code")]
        public int PostalCode { get; set; }

        [Required(ErrorMessage = "El número de telefono es requerido")]
        [Display(Name = "Phone number")]
        public int PhoneNumber { get; set; }

        [DefaultValue(false)]
        public bool IsDeleted { get; set; }
    }
}
