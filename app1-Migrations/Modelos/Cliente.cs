using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace app1_Migrations.Modelos
{
    public class Cliente
    {
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "VARCHAR(20)")]

        public string Nombre { get; set; }
        [Required]
        [Column(TypeName = "VARCHAR(20)")]
        
        public string Apellido { get; set; }
        [Required]
        [Column(TypeName = "VARCHAR(20)")]
        
        public string Direccion { get; set; }
        [Required]
        [Column(TypeName = "VARCHAR(40)")]
        
        public string Telefono { get; set; }
        [Required]
        [Column(TypeName = "VARCHAR(10)")]
        
        public string Fecha_nac { get; set; }
        [Required]
        [Column(TypeName = "VARCHAR(10)")]

        public Boolean Estado { get; set; }
    }
}
