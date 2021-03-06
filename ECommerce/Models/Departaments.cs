﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerce.Models
{
    public class Departaments
    {
        [Key]
        [Display(Name = "Departamento")]
        public int DepartamentsId { get; set; }

        [Required(ErrorMessage ="O Campo Nome é Obrigatório!")]
        [Display(Name = "Nome")]
        [MaxLength(50, ErrorMessage = "O nome nao deve conter mais que 50 caracteres!!")]
        [Index("Departaments_Name_Index",IsUnique = true)]
        public string Name { get; set; }

        public virtual ICollection<City> Cities { get; set; }
        public virtual ICollection<Company> Company { get; set; }
        public virtual ICollection<User> User { get; set; }
        public virtual ICollection<WareHouse> WareHouse { get; set; }
    }
}