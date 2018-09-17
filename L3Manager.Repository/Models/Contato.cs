namespace L3Manager.Repository.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Contato")]
    public partial class Contato
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        public string Cargo { get; set; }

        [Column("Data de Nascimento")]
        public string Data_de_Nascimento { get; set; }

        public string Telefone { get; set; }

        public string Email { get; set; }

        public int Id_Cliente { get; set; }

        public virtual Cliente Cliente { get; set; }
    }
}
