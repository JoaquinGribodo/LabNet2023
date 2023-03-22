using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lab.EF.MVC.Models
{
    public class CategoriesView
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo Nombre no puede estar vacío.")]
        [StringLength(15)]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El campo Descripción no puede estar vacío.")]
        [StringLength(80)]
        public string Descripcion { get; set; }

    }
}