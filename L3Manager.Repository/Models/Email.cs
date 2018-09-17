namespace L3Manager.Repository.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Email")]
    public partial class Email
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Column("Email")]
        [Required]
        public string Email1 { get; set; }

        public int? Id_Cliente { get; set; }

        public virtual Cliente Cliente { get; set; }
    }
}
