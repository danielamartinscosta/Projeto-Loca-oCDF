using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace locacaoProjeto.Models
{

    [Table("Pedidos")]
    public class Pedido
    {

        [Display(Name = "Código")]
        [Column("Id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; } = default!;

        [Display(Name = "Código_Cliente")]
        [Column("ClienteId")]
        public int ClienteId { get; set; } = default!;

        public Cliente? Cliente {get; set; }

        [Display(Name = "Carro")]
        [Column("CarroId")]
        public int CarroId { get; set; } = default!;

        public Carro? Carro { get; set; }

        [Display(Name = "Data de Locação")]
        [Column("DataDeLocacao")]
        public DateTime DataLocacao { get; set; } = default!;

        [Display(Name = "Data de Entrega")]
        [Column("DataDeEntrega")]
        public DateTime DataEntrega { get; set; } = default!;
    }
}
