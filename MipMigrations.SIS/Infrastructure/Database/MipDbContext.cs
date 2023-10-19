using MipMigrations.SIS.Domain.Application.Entities;
using Microsoft.EntityFrameworkCore;
using MipMigrations.SIS.Domain.Application.Enums;

namespace MipMigrations.SIS.Infrastructure.Database;

public class MipSisDbContext : DbContext
{
    public MipSisDbContext(DbContextOptions<MipSisDbContext> options) : base(options) { }

    public DbSet<TenantEntity> Tenants => Set<TenantEntity>(); // 001
    public DbSet<EmpresaEntity> Empresas => Set<EmpresaEntity>(); // 002
    public DbSet<PessoaEntity> Pessoas => Set<PessoaEntity>(); // 003
    public DbSet<EmpresaPessoaEntity> EmpresaPessoas => Set<EmpresaPessoaEntity>(); // 004
    public DbSet<UsuarioEntity> Usuarios => Set<UsuarioEntity>(); // 005
    public DbSet<TipoUsuarioEntity> TipoUsuarios => Set<TipoUsuarioEntity>(); // 006
    public DbSet<PlanoEntity> Planos => Set<PlanoEntity>(); // 007
    public DbSet<TenantPlanoEntity> TenantPlanos => Set<TenantPlanoEntity>(); // 008
    public DbSet<ServicoEntity> Servicos => Set<ServicoEntity>(); // 009
    public DbSet<NodoServicoEntity> NodoServicos => Set<NodoServicoEntity>(); // 010
    public DbSet<EstadoEntity> Estados => Set<EstadoEntity>(); // 011
    public DbSet<CidadeEntity> Cidades => Set<CidadeEntity>(); // 012
    public DbSet<EnderecoEntity> Enderecos => Set<EnderecoEntity>(); // 013
    public DbSet<ContatoEntity> Contatos => Set<ContatoEntity>(); // 014
    public DbSet<EmpresaImagemEntity> EmpresaImagens => Set<EmpresaImagemEntity>(); // 015
    public DbSet<PessoaImagemEntity> PessoaImagens => Set<PessoaImagemEntity>();// 016
    public DbSet<CnaeEntity> Cnaes => Set<CnaeEntity>(); // 017
    public DbSet<EmpresaCnaeEntity> EmpresaCnaes => Set<EmpresaCnaeEntity>(); // 018
    public DbSet<TipoEnderecoEntity> TipoEnderecos => Set<TipoEnderecoEntity>(); // 019
    public DbSet<SegmentoEntity> Segmentos => Set<SegmentoEntity>(); // 020
    public DbSet<PlanoNodoServicoEntity> PlanoNodoServicos => Set<PlanoNodoServicoEntity>(); // 021
    public DbSet<EmpresaSegmentoEntity> EmpresaSegmentos => Set<EmpresaSegmentoEntity>(); // 022

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Model
            .GetEntityTypes()
            .SelectMany(e => e.GetForeignKeys())
            .ToList()
            .ForEach(e => e.DeleteBehavior = DeleteBehavior.Restrict);

        modelBuilder.Entity<EmpresaEntity>()
            .HasOne(p => p.Contato)
            .WithOne(i => i.Empresa)
            .HasForeignKey<ContatoEntity>(b => b.EmpresaId);

        modelBuilder.Entity<PessoaEntity>()
            .HasOne(p => p.Contato)
            .WithOne(i => i.Pessoa)
            .HasForeignKey<ContatoEntity>(b => b.PessoaId);

        modelBuilder.Entity<EmpresaEntity>()
            .HasOne(p => p.EnderecoFiscal)
            .WithOne(i => i.Empresa)
            .HasForeignKey<EnderecoEntity>(b => b.EmpresaId);

        modelBuilder.Entity<PessoaEntity>()
            .HasOne(p => p.Usuario)
            .WithOne(i => i.Pessoa)
            .HasForeignKey<UsuarioEntity>(b => b.PessoaId);
    }
}