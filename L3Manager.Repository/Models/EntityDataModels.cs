namespace L3Manager.Repository.Models
{
    using System.Data.Entity;

    public partial class EntityDataModels : DbContext
    {
        public EntityDataModels()
            : base("name=L3Solutions")
        {
        }

        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Contato> Contatoes { get; set; }
        public virtual DbSet<Email> Emails { get; set; }
        public virtual DbSet<Endereco> Enderecoes { get; set; }
        public virtual DbSet<Telefone> Telefones { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>()
                .Property(e => e.Documento);

            modelBuilder.Entity<Cliente>()
                .HasMany(e => e.Contatoes)
                .WithRequired(e => e.Cliente)
                .HasForeignKey(e => e.Id_Cliente)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Cliente>()
                .HasMany(e => e.Emails)
                .WithOptional(e => e.Cliente)
                .HasForeignKey(e => e.Id_Cliente);

            modelBuilder.Entity<Cliente>()
                .HasMany(e => e.Enderecoes)
                .WithRequired(e => e.Cliente)
                .HasForeignKey(e => e.Id_Cliente)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Cliente>()
                .HasMany(e => e.Telefones)
                .WithRequired(e => e.Cliente)
                .HasForeignKey(e => e.Id_Cliente)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Telefone>()
                .Property(e => e.Numero)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.Nome)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.Usuario1)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .HasMany(e => e.Clientes)
                .WithRequired(e => e.Usuario)
                .HasForeignKey(e => e.Id_Vendedor)
                .WillCascadeOnDelete(false);
        }
    }
}
