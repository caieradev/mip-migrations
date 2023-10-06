using MipMigrations.Domain.Application.Entities;
using Microsoft.EntityFrameworkCore;
using MipMigrations.Infrastructure.Database.Mapping;
using MipMigrations.Domain.Application.Enums;

namespace MipMigrations.Infrastructure.Database;

public class MipDbContext : DbContext
{
    public MipDbContext(DbContextOptions<MipDbContext> options) : base(options) { }

    // SIS
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
    public DbSet<CnaeEntity> Cnaes => Set<CnaeEntity>(); // SIS017
    public DbSet<EmpresaCnaeEntity> EmpresaCnaes => Set<EmpresaCnaeEntity>(); // SIS018
    public DbSet<TipoEnderecoEntity> TipoEnderecos => Set<TipoEnderecoEntity>(); // SIS019
    public DbSet<SegmentoEntity> Segmentos => Set<SegmentoEntity>(); // SIS020
    public DbSet<PlanoNodoServicoEntity> PlanoNodoServicos => Set<PlanoNodoServicoEntity>(); // SIS021
    public DbSet<EmpresaSegmentoEntity> EmpresaSegmentos => Set<EmpresaSegmentoEntity>(); // SIS022

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // SIS
        modelBuilder.ApplyConfiguration(new TenantMapping());  // SIS001
        modelBuilder.ApplyConfiguration(new EmpresaMapping()); // SIS002
        modelBuilder.ApplyConfiguration(new PessoaMapping()); // SIS003
        modelBuilder.ApplyConfiguration(new EmpresaPessoaMapping()); // SIS004
        modelBuilder.ApplyConfiguration(new UsuarioMapping()); // SIS005
        modelBuilder.ApplyConfiguration(new TipoUsuarioMapping()); // SIS006
        modelBuilder.ApplyConfiguration(new PlanoMapping()); // SIS007
        modelBuilder.ApplyConfiguration(new TenantPlanoMapping()); // SIS008
        modelBuilder.ApplyConfiguration(new ServicoMapping()); // SIS009
        modelBuilder.ApplyConfiguration(new NodoServicoMapping()); // SIS010
        modelBuilder.ApplyConfiguration(new EstadoMapping()); // SIS011
        modelBuilder.ApplyConfiguration(new CidadeMapping()); // SIS012
        modelBuilder.ApplyConfiguration(new EnderecoMapping()); // SIS013
        modelBuilder.ApplyConfiguration(new ContatoMapping()); // SIS014
        modelBuilder.ApplyConfiguration(new EmpresaImagemMapping()); // SIS015
        modelBuilder.ApplyConfiguration(new PessoaImagemMapping()); // SIS016
        modelBuilder.ApplyConfiguration(new CnaeMapping()); // SIS017
        modelBuilder.ApplyConfiguration(new EmpresaCnaeMapping()); // SIS018
        modelBuilder.ApplyConfiguration(new TipoEnderecoMapping()); // SIS019
        modelBuilder.ApplyConfiguration(new SegmentoMapping()); // SIS020
        modelBuilder.ApplyConfiguration(new PlanoNodoServicoMapping()); // SIS021
        modelBuilder.ApplyConfiguration(new EmpresaSegmentoMapping()); // SIS022
    }
}