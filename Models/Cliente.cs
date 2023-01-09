using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace locacaoProjeto.Models
{

    [Table("Clientes")]
    public class Cliente
    {

        [Display(Name = "Código")]
        [Column("Id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; } = default!;

        [Display(Name = "Nome")]
        [Column("Nome")]
        public string Nome { get; set; } = default!;

        [Display(Name = "Email")]
        [Column("Email")]
        public string Email { get; set; } = default!;

        [Display(Name = "Telefone")]
        [Column("Telefone")]
        public string Telefone { get; set; } = default!;

        [Display(Name = "Endereco")]
        [Column("Endereco")]
        public string Endereco { get; set; } = default!;
    }
}
