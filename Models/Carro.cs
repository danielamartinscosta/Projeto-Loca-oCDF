using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace locacaoProjeto.Models
{

    [Table("Carros")]
    public class Carro
    {
        [Display(Name = "Código")]
        [Column("Id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; } = default!;

        [Display(Name = "Nome")]
        [Column("Nome")]
        public string Nome { get; set; } = default!;


        [Display(Name = "Modelo")]
        [Column("ModeloId")]
        public int ModeloId { get; set; } = default!;

        public Modelo? Modelo { get; set; }


    }
}
