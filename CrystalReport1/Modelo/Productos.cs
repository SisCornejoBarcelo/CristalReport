using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CrystalReport1.Modelo
{
    [Table("Productos")]
   public class Productos
    {
        [Key]
        public int pkProducto { get; set; }

        [Required(ErrorMessage = "Se require el nombre costo")]
        [StringLength(50)]
        public String sNombreCorto { get; set; }

        [Required(ErrorMessage = "Se requirela descripcion")]
        [StringLength(150)]
        public String sDescripcion { get; set; }

        [Required(ErrorMessage = "Se require la clasificacion")]
        [StringLength(40)]
        public String sDepartamento { get; set; }

        [Required(ErrorMessage = "Se require el precio")]
        public double dPrecio { get; set; }

        [Required(ErrorMessage = "Se require el costro")]
        public double dCosto { get; set; }

        [Required(ErrorMessage = "Se require el stock")]
        public int bStock { get; set; }

        [Required(ErrorMessage = "Se require el status")]
        public Boolean bStatus { get; set; }

        public Productos()
        {
            this.bStatus = true;
   
        }
    }
}
