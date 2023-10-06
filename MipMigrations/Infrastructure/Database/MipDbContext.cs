using MipMigrations.Domain.Application.Entities;
using Microsoft.EntityFrameworkCore;

namespace MipMigrations.Infrastructure.Database;

public class MipDbContext : DbContext
{
    public MipDbContext(DbContextOptions<MipDbContext> options) : base(options) { }

    public DbSet<TenantEntity> Tenants => Set<TenantEntity>(); // SIS001
    public DbSet<EmpresaEntity> Empresas => Set<EmpresaEntity>(); // SIS002
    public DbSet<PessoaEntity> Pessoas => Set<PessoaEntity>(); // SIS003
    public DbSet<EmpresaPessoaEntity> EmpresaPessoas => Set<EmpresaPessoaEntity>(); // SIS004
    public DbSet<UsuarioEntity> Usuarios => Set<UsuarioEntity>(); // SIS005
    public DbSet<TipoUsuarioEntity> TipoUsuarios => Set<TipoUsuarioEntity>(); // SIS006
    public DbSet<PlanoEntity> Planos => Set<PlanoEntity>(); // SIS007
    public DbSet<TenantPlanoEntity> TenantPlanos => Set<TenantPlanoEntity>(); // SIS008
    public DbSet<ServicoEntity> Servicos => Set<ServicoEntity>(); // SIS009
    public DbSet<NodoServicoEntity> NodoServicos => Set<NodoServicoEntity>(); // SIS010
    public DbSet<EstadoEntity> Estados => Set<EstadoEntity>(); // SIS011
    public DbSet<CidadeEntity> Cidades => Set<CidadeEntity>(); // SIS012
    public DbSet<EnderecoEntity> Enderecos => Set<EnderecoEntity>(); // SIS013
    public DbSet<ContatoEntity> Contatos => Set<ContatoEntity>(); // SIS014
    public DbSet<EmpresaImagemEntity> EmpresaImagens => Set<EmpresaImagemEntity>(); // SIS015
    public DbSet<PessoaImagemEntity> PessoaImagens => Set<PessoaImagemEntity>();// SIS016

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        throw new NotImplementedException();
    }
}