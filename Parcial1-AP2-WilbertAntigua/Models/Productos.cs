using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Parcial1_AP2_WilbertAntigua.Models
{
    public class Productos
    {
        [Key]
        public int ProductoId { get; set; }

        [Required(ErrorMessage ="Este campo es obligatorio")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public int Existencia { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public decimal Costo { get; set; }

        public decimal ValorInvertario { get; set; }

    }
}
