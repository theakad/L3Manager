namespace L3Manager.Repository.Models
{
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Telefone")]
    public partial class Telefone
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public decimal Numero { get; set; }

        public int Id_Cliente { get; set; }

        public virtual Cliente Cliente { get; set; }
    }
}
