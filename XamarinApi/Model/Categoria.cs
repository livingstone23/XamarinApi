using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace XamarinApi.Model
{
    public class Categoria
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IddCategoria { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public bool BHabilitado { get; set; }
        public string Foto { get; set; }
    }
}
