using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TreSorelle.Models;

namespace TreSorelle.Data;

public class AppDbContext : IdentityDbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Produto> Produtos { get; set; }
    public DbSet<ProdutoAvaliacao> ProdutoAvaliacoes { get; set; }
    public DbSet<Tipo> Tipos { get; set; }
    public DbSet<Usuario> Usuarios { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        AppDbSeed appDbSeed = new(builder);

    #region Relacionamento Muito para Muitos - ProdutoAvaliacao
        builder.Entity<ProdutoAvaliacao>().HasKey(
            pa => new{pa.ProdutoId, pa.UsuarioId}
        );

        builder.Entity<ProdutoAvaliacao>()
            .HasOne(pa => pa.Produto)
            .WithMany(p => p.Avaliacoes)
            .HasForeignKey(pa => pa.ProdutoId);

        builder.Entity<ProdutoAvaliacao>()
            .HasOne(pa => pa.Usuario)
            .WithMany(u => u.Avaliacoes)
            .HasForeignKey(pa => pa.UsuarioId);
        #endregion

    }

}