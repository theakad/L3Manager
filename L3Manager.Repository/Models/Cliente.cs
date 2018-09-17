namespace L3Manager.Repository.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Cliente")]
    public partial class Cliente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cliente()
        {
            Contatoes = new HashSet<Contato>();
            Emails = new HashSet<Email>();
            Enderecoes = new HashSet<Endereco>();
            Telefones = new HashSet<Telefone>();
        }

        [Display(Name = "Cod.")]
        public int Id { get; set; }

        public bool Tipo { get; set; }

        [Required]
        public string Nome { get; set; }

        [Display(Name = "CPF/CNPJ")]
        public decimal? Documento { get; set; }

        public DateTime Data_Hora_Cadastro { get; set; }

        [Display(Name = "Vencimento da Licença")]
        public DateTime? Vencimento_Licenca { get; set; }

        [Display(Name = "Vendedor")]
        public int Id_Vendedor { get; set; }

        public virtual Usuario Usuario { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Contato> Contatoes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Email> Emails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Endereco> Enderecoes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Telefone> Telefones { get; set; }
    }
}
