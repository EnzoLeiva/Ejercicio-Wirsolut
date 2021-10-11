using Ejercicio_Wirsolut.Data;
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

        [Required(ErrorMessage = "The name is required")]
        [StringLength(30)]      
        public string Name { get; set; }

        [Required(ErrorMessage = "The surname is required")]
        [StringLength(30)]
        public string Surname { get; set; }

        [Required(ErrorMessage = "The email is required")]
        [StringLength(250)]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "The DNI is required")]
        public int DNI { get; set; }

        [Required(ErrorMessage = "The date of birth is required")]
        [Display(Name = "Date of birth")]
        [DataType(DataType.DateTime)]
        public DateTime DateOfBirth { get; set; }

        [Required(ErrorMessage = "The direction is required")]
        [StringLength(250)]
        public string Direction { get; set; }

        [Required(ErrorMessage = "The postal code is required")]
        [Display(Name = "Postal code")]
        public int PostalCode { get; set; }

        [Required(ErrorMessage = "The phone number is required")]
        [Display(Name = "Phone number")]
        [Phone]
        public string PhoneNumber { get; set; }

        [DefaultValue(false)]
        public bool IsDeleted { get; set; }
    }

}
