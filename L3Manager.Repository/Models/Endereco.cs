namespace L3Manager.Repository.Models
{
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Endereco")]
    public partial class Endereco
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public string Logradouro { get; set; }

        public int? Numero { get; set; }

        public string Complemento { get; set; }

        public string Bairro { get; set; }

        public string Cidade { get; set; }

        public string Estado { get; set; }

        public int Id_Cliente { get; set; }

        public virtual Cliente Cliente { get; set; }
    }
}
