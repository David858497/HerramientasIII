using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Feriados.Dominio.Entidades
{
    [Table("Tipo")]
    public class Tipo
    {
        [Column("Id")]
        public int Id { get; set; }

        [Column("Tipo"), StringLength(100)]
        public string Type { get; set; }
    }
}
