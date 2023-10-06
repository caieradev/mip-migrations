using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MipMigrations.Infrastructure.Database.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SIS001_TENANT",
                columns: table => new
                {
                    SIS001_TENANT_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SIS001_ATIVO = table.Column<bool>(type: "bit", nullable: false),
                    SIS001_DATA_CADASTRO = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    SIS001_DATA_ATUALIZACAO = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    SIS001_NOME = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SIS001_CAIERA_DEV = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SIS001_TENANT", x => x.SIS001_TENANT_ID);
                });

            migrationBuilder.CreateTable(
                name: "SIS006_TIPO_USUARIO",
                columns: table => new
                {
                    SIS006_TIPO_USUARIO_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SIS006_ATIVO = table.Column<bool>(type: "bit", nullable: false),
                    SIS006_DATA_CADASTRO = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    SIS006_DATA_ATUALIZACAO = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    SIS006_DESCRICAO = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SIS006_TIPO_USUARIO", x => x.SIS006_TIPO_USUARIO_ID);
                });

            migrationBuilder.CreateTable(
                name: "SIS007_PLANO",
                columns: table => new
                {
                    SIS007_PLANO_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SIS007_NOME = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SIS007_VALOR = table.Column<double>(type: "float", nullable: false),
                    SIS007_ATIVO = table.Column<bool>(type: "bit", nullable: false),
                    SIS007_DATA_CADASTRO = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    SIS007_DATA_ATUALIZACAO = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    SIS007_DESCRICAO = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SIS007_PLANO", x => x.SIS007_PLANO_ID);
                });

            migrationBuilder.CreateTable(
                name: "SIS009_SERVICO",
                columns: table => new
                {
                    SIS009_SERVICO_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SIS009_NOME = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SIS009_ATIVO = table.Column<bool>(type: "bit", nullable: false),
                    SIS009_DATA_CADASTRO = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    SIS009_DATA_ATUALIZACAO = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    SIS009_DESCRICAO = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SIS009_SERVICO", x => x.SIS009_SERVICO_ID);
                });

            migrationBuilder.CreateTable(
                name: "SIS011_ESTADO",
                columns: table => new
                {
                    SIS011_ESTADO_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SIS011_ATIVO = table.Column<bool>(type: "bit", nullable: false),
                    SIS011_DATA_CADASTRO = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    SIS011_DATA_ATUALIZACAO = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    SIS011_CODIGO_IBGE = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SIS011_NOME = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SIS011_SIGLA = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SIS011_ESTADO", x => x.SIS011_ESTADO_ID);
                });

            migrationBuilder.CreateTable(
                name: "SIS017_CNAE",
                columns: table => new
                {
                    SIS017_CNAE_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SIS017_CODIGO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SIS017_ATIVO = table.Column<bool>(type: "bit", nullable: false),
                    SIS017_DATA_CADASTRO = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    SIS017_DATA_ATUALIZACAO = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SIS017_CNAE", x => x.SIS017_CNAE_ID);
                });

            migrationBuilder.CreateTable(
                name: "SIS019_TIPO_ENDERECO",
                columns: table => new
                {
                    SIS019_TIPO_ENDERECO_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SIS019_ATIVO = table.Column<bool>(type: "bit", nullable: false),
                    SIS019_DATA_CADASTRO = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    SIS019_DATA_ATUALIZACAO = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    SIS019_DESCRICAO = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SIS019_TIPO_ENDERECO", x => x.SIS019_TIPO_ENDERECO_ID);
                });

            migrationBuilder.CreateTable(
                name: "SIS020_SEGMENTO",
                columns: table => new
                {
                    SIS020_SEGMENTO_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SIS020_ATIVO = table.Column<bool>(type: "bit", nullable: false),
                    SIS020_DATA_CADASTRO = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    SIS020_DATA_ATUALIZACAO = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    SIS020_DESCRICAO = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SIS020_SEGMENTO", x => x.SIS020_SEGMENTO_ID);
                });

            migrationBuilder.CreateTable(
                name: "SIS008_TENANT_PLANO",
                columns: table => new
                {
                    SIS008_TENANT_PLANO_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SIS008_ATIVO = table.Column<bool>(type: "bit", nullable: false),
                    SIS008_DATA_CADASTRO = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    SIS008_DATA_ATUALIZACAO = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    SIS001_TENANT_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SIS007_PLANO_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SIS008_TENANT_PLANO", x => x.SIS008_TENANT_PLANO_ID);
                    table.ForeignKey(
                        name: "FK_SIS008_TENANT_PLANO_SIS001_TENANT_SIS001_TENANT_ID",
                        column: x => x.SIS001_TENANT_ID,
                        principalTable: "SIS001_TENANT",
                        principalColumn: "SIS001_TENANT_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SIS008_TENANT_PLANO_SIS007_PLANO_SIS007_PLANO_ID",
                        column: x => x.SIS007_PLANO_ID,
                        principalTable: "SIS007_PLANO",
                        principalColumn: "SIS007_PLANO_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SIS010_NODO_SERVICO",
                columns: table => new
                {
                    SIS010_NODO_SERVICO_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SIS010_ATIVO = table.Column<bool>(type: "bit", nullable: false),
                    SIS010_DATA_CADASTRO = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    SIS010_DATA_ATUALIZACAO = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    SIS010_TAIL = table.Column<bool>(type: "bit", nullable: false),
                    SIS010_ROOT = table.Column<bool>(type: "bit", nullable: false),
                    SIS009_SERVICO_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SIS009_SERVICO_PAI_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SIS010_NODO_SERVICO", x => x.SIS010_NODO_SERVICO_ID);
                    table.ForeignKey(
                        name: "FK_SIS010_NODO_SERVICO_SIS009_SERVICO_SIS009_SERVICO_ID",
                        column: x => x.SIS009_SERVICO_ID,
                        principalTable: "SIS009_SERVICO",
                        principalColumn: "SIS009_SERVICO_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SIS010_NODO_SERVICO_SIS010_NODO_SERVICO_SIS009_SERVICO_ID",
                        column: x => x.SIS009_SERVICO_ID,
                        principalTable: "SIS010_NODO_SERVICO",
                        principalColumn: "SIS010_NODO_SERVICO_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SIS012_CIDADE",
                columns: table => new
                {
                    SIS012_CIDADE_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SIS012_ATIVO = table.Column<bool>(type: "bit", nullable: false),
                    SIS012_DATA_CADASTRO = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    SIS012_DATA_ATUALIZACAO = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    SIS012_CODIGO_IBGE = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SIS012_NOME = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SIS011_ESTADO_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SIS012_CIDADE", x => x.SIS012_CIDADE_ID);
                    table.ForeignKey(
                        name: "FK_SIS012_CIDADE_SIS011_ESTADO_SIS011_ESTADO_ID",
                        column: x => x.SIS011_ESTADO_ID,
                        principalTable: "SIS011_ESTADO",
                        principalColumn: "SIS011_ESTADO_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SIS021_PLANO_NODO_SERVICO",
                columns: table => new
                {
                    SIS021_PLANO_NODO_SERVICO_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SIS021_ATIVO = table.Column<bool>(type: "bit", nullable: false),
                    SIS021_DATA_CADASTRO = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    SIS021_DATA_ATUALIZACAO = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    SIS007_PLANO_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SIS010_NODO_SERVICO_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SIS021_PLANO_NODO_SERVICO", x => x.SIS021_PLANO_NODO_SERVICO_ID);
                    table.ForeignKey(
                        name: "FK_SIS021_PLANO_NODO_SERVICO_SIS007_PLANO_SIS007_PLANO_ID",
                        column: x => x.SIS007_PLANO_ID,
                        principalTable: "SIS007_PLANO",
                        principalColumn: "SIS007_PLANO_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SIS021_PLANO_NODO_SERVICO_SIS010_NODO_SERVICO_SIS010_NODO_SERVICO_ID",
                        column: x => x.SIS010_NODO_SERVICO_ID,
                        principalTable: "SIS010_NODO_SERVICO",
                        principalColumn: "SIS010_NODO_SERVICO_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SIS002_EMPRESA",
                columns: table => new
                {
                    SIS002_EMPRESA_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SIS002_ATIVO = table.Column<bool>(type: "bit", nullable: false),
                    SIS002_DATA_CADASTRO = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    SIS002_DATA_ATUALIZACAO = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    SIS002_RAZAO_SOCIAL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SIS002_NOME_FANTASIA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SIS002_CNPJ = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SIS002_INSCRICAO_ESTADUAL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SIS002_ISENTO_INSCRICAO_ESTADUAL = table.Column<bool>(type: "bit", nullable: false),
                    SIS002_INSCRICAO_MUNICIPAL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SIS002_ATIVIDADE_PRINCIPAL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SIS002_DESCRICAO_ATIVIDADE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SIS002_REGIME_TRIBUTARIO = table.Column<int>(type: "int", nullable: false),
                    SIS002_TAMANHO_EMPRESA = table.Column<int>(type: "int", nullable: false),
                    SIS002_FATURAMENTO_ULTIMO_ANO = table.Column<int>(type: "int", nullable: false),
                    SIS002_NUMERO_FUNCIONARIOS = table.Column<int>(type: "int", nullable: false),
                    SIS013_ENDERECO_FISCAL_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SIS014_CONTATO_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SIS001_TENANT_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SIS002_EMPRESA", x => x.SIS002_EMPRESA_ID);
                    table.ForeignKey(
                        name: "FK_SIS002_EMPRESA_SIS001_TENANT_SIS001_TENANT_ID",
                        column: x => x.SIS001_TENANT_ID,
                        principalTable: "SIS001_TENANT",
                        principalColumn: "SIS001_TENANT_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SIS014_CONTATO",
                columns: table => new
                {
                    SIS014_CONTATO_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SIS014_TELEFONE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SIS014_CELULAR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SIS014_EMAIL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SIS014_EMAIL_COBRANCA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SIS014_SITE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmpresaId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PessoaId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SIS014_ATIVO = table.Column<bool>(type: "bit", nullable: false),
                    SIS014_DATA_CADASTRO = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    SIS014_DATA_ATUALIZACAO = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    SIS014_DESCRICAO = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SIS014_CONTATO", x => x.SIS014_CONTATO_ID);
                    table.ForeignKey(
                        name: "FK_SIS014_CONTATO_SIS002_EMPRESA_SIS014_CONTATO_ID",
                        column: x => x.SIS014_CONTATO_ID,
                        principalTable: "SIS002_EMPRESA",
                        principalColumn: "SIS002_EMPRESA_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SIS015_EMPRESA_IMAGEM",
                columns: table => new
                {
                    SIS015_EMPRESA_IMAGEM_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SIS015_ATIVO = table.Column<bool>(type: "bit", nullable: false),
                    SIS015_DATA_CADASTRO = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    SIS015_DATA_ATUALIZACAO = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    SIS015_IMAGE_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SIS015_FILE_NAME = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SIS015_CONTENT_TYPE = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SIS015_FILE_SIZE = table.Column<long>(type: "bigint", nullable: false),
                    SIS015_THUMB_IMAGE_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SIS015_THUMB_CONTENT_TYPE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SIS015_THUMB_FILE_SIZE = table.Column<long>(type: "bigint", nullable: true),
                    SIS002_EMPRESA_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SIS015_EMPRESA_IMAGEM", x => x.SIS015_EMPRESA_IMAGEM_ID);
                    table.ForeignKey(
                        name: "FK_SIS015_EMPRESA_IMAGEM_SIS002_EMPRESA_SIS002_EMPRESA_ID",
                        column: x => x.SIS002_EMPRESA_ID,
                        principalTable: "SIS002_EMPRESA",
                        principalColumn: "SIS002_EMPRESA_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SIS018_EMPRESA_CNAE",
                columns: table => new
                {
                    SIS018_EMPRESA_CNAE_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SIS018_ATIVO = table.Column<bool>(type: "bit", nullable: false),
                    SIS018_DATA_CADASTRO = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    SIS018_DATA_ATUALIZACAO = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    SIS018_CNAE_PRINCIPAL = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    SIS002_EMPRESA_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SIS017_CNAE_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SIS018_EMPRESA_CNAE", x => x.SIS018_EMPRESA_CNAE_ID);
                    table.ForeignKey(
                        name: "FK_SIS018_EMPRESA_CNAE_SIS002_EMPRESA_SIS002_EMPRESA_ID",
                        column: x => x.SIS002_EMPRESA_ID,
                        principalTable: "SIS002_EMPRESA",
                        principalColumn: "SIS002_EMPRESA_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SIS018_EMPRESA_CNAE_SIS017_CNAE_SIS017_CNAE_ID",
                        column: x => x.SIS017_CNAE_ID,
                        principalTable: "SIS017_CNAE",
                        principalColumn: "SIS017_CNAE_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SIS022_EMPRESA_SEGMENTO",
                columns: table => new
                {
                    SIS022_EMPRESA_SEGMENTO_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SIS022_ATIVO = table.Column<bool>(type: "bit", nullable: false),
                    SIS022_DATA_CADASTRO = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    SIS022_DATA_ATUALIZACAO = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    SIS002_EMPRESA_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SIS020_SEGMENTO_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SIS022_EMPRESA_SEGMENTO", x => x.SIS022_EMPRESA_SEGMENTO_ID);
                    table.ForeignKey(
                        name: "FK_SIS022_EMPRESA_SEGMENTO_SIS002_EMPRESA_SIS002_EMPRESA_ID",
                        column: x => x.SIS002_EMPRESA_ID,
                        principalTable: "SIS002_EMPRESA",
                        principalColumn: "SIS002_EMPRESA_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SIS022_EMPRESA_SEGMENTO_SIS020_SEGMENTO_SIS020_SEGMENTO_ID",
                        column: x => x.SIS020_SEGMENTO_ID,
                        principalTable: "SIS020_SEGMENTO",
                        principalColumn: "SIS020_SEGMENTO_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SIS003_PESSOA",
                columns: table => new
                {
                    SIS003_PESSOA_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SIS003_ATIVO = table.Column<bool>(type: "bit", nullable: false),
                    SIS003_DATA_CADASTRO = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    SIS003_DATA_ATUALIZACAO = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    SIS003_NOME = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SIS003_DATA_NASCIMENTO = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    SIS003_CPF = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SIS001_TENANT_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SIS014_CONTATO_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SIS005_USUARIO_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SIS003_PESSOA", x => x.SIS003_PESSOA_ID);
                    table.ForeignKey(
                        name: "FK_SIS003_PESSOA_SIS001_TENANT_SIS001_TENANT_ID",
                        column: x => x.SIS001_TENANT_ID,
                        principalTable: "SIS001_TENANT",
                        principalColumn: "SIS001_TENANT_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SIS003_PESSOA_SIS014_CONTATO_SIS014_CONTATO_ID",
                        column: x => x.SIS014_CONTATO_ID,
                        principalTable: "SIS014_CONTATO",
                        principalColumn: "SIS014_CONTATO_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SIS004_EMPRESA_PESSOA",
                columns: table => new
                {
                    SIS004_EMPRESA_PESSOA_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SIS004_ATIVO = table.Column<bool>(type: "bit", nullable: false),
                    SIS004_DATA_CADASTRO = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    SIS004_DATA_ATUALIZACAO = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    SIS004_SOCIO = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    SIS002_EMPRESA_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SIS003_PESSOA_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SIS004_EMPRESA_PESSOA", x => x.SIS004_EMPRESA_PESSOA_ID);
                    table.ForeignKey(
                        name: "FK_SIS004_EMPRESA_PESSOA_SIS002_EMPRESA_SIS002_EMPRESA_ID",
                        column: x => x.SIS002_EMPRESA_ID,
                        principalTable: "SIS002_EMPRESA",
                        principalColumn: "SIS002_EMPRESA_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SIS004_EMPRESA_PESSOA_SIS003_PESSOA_SIS003_PESSOA_ID",
                        column: x => x.SIS003_PESSOA_ID,
                        principalTable: "SIS003_PESSOA",
                        principalColumn: "SIS003_PESSOA_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SIS005_USUARIO",
                columns: table => new
                {
                    SIS005_USUARIO_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SIS005_ATIVO = table.Column<bool>(type: "bit", nullable: false),
                    SIS005_DATA_CADASTRO = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    SIS005_DATA_ATUALIZACAO = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    SIS005_SENHA = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SIS005_USUARIO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SIS003_PESSOA_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SIS006_TIPO_USUARIO_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SIS005_USUARIO", x => x.SIS005_USUARIO_ID);
                    table.ForeignKey(
                        name: "FK_SIS005_USUARIO_SIS003_PESSOA_SIS003_PESSOA_ID",
                        column: x => x.SIS003_PESSOA_ID,
                        principalTable: "SIS003_PESSOA",
                        principalColumn: "SIS003_PESSOA_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SIS005_USUARIO_SIS006_TIPO_USUARIO_SIS006_TIPO_USUARIO_ID",
                        column: x => x.SIS006_TIPO_USUARIO_ID,
                        principalTable: "SIS006_TIPO_USUARIO",
                        principalColumn: "SIS006_TIPO_USUARIO_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SIS013_ENDERECO",
                columns: table => new
                {
                    SIS013_ENDERECO_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SIS013_ATIVO = table.Column<bool>(type: "bit", nullable: false),
                    SIS013_DATA_CADASTRO = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    SIS013_DATA_ATUALIZACAO = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    SIS013_CEP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SIS013_BAIRRO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SIS013_LOGRADOURO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SIS013_NUMERO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SIS013_COMPLEMENTO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SIS012_CIDADE_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SIS019_TIPO_ENDERECO_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SIS002_EMPRESA_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SIS003_PESSOA_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SIS013_ENDERECO", x => x.SIS013_ENDERECO_ID);
                    table.ForeignKey(
                        name: "FK_SIS013_ENDERECO_SIS003_PESSOA_SIS003_PESSOA_ID",
                        column: x => x.SIS003_PESSOA_ID,
                        principalTable: "SIS003_PESSOA",
                        principalColumn: "SIS003_PESSOA_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SIS013_ENDERECO_SIS012_CIDADE_SIS012_CIDADE_ID",
                        column: x => x.SIS012_CIDADE_ID,
                        principalTable: "SIS012_CIDADE",
                        principalColumn: "SIS012_CIDADE_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SIS013_ENDERECO_SIS019_TIPO_ENDERECO_SIS019_TIPO_ENDERECO_ID",
                        column: x => x.SIS019_TIPO_ENDERECO_ID,
                        principalTable: "SIS019_TIPO_ENDERECO",
                        principalColumn: "SIS019_TIPO_ENDERECO_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SIS016_PESSOA_IMAGEM",
                columns: table => new
                {
                    SIS016_PESSOA_IMAGEM_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SIS016_ATIVO = table.Column<bool>(type: "bit", nullable: false),
                    SIS016_DATA_CADASTRO = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    SIS016_DATA_ATUALIZACAO = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    SIS016_IMAGE_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SIS016_FILE_NAME = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SIS016_CONTENT_TYPE = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SIS016_FILE_SIZE = table.Column<long>(type: "bigint", nullable: false),
                    SIS016_THUMB_IMAGE_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SIS016_THUMB_CONTENT_TYPE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SIS016_THUMB_FILE_SIZE = table.Column<long>(type: "bigint", nullable: true),
                    SIS003_PESSOA_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SIS016_PESSOA_IMAGEM", x => x.SIS016_PESSOA_IMAGEM_ID);
                    table.ForeignKey(
                        name: "FK_SIS016_PESSOA_IMAGEM_SIS003_PESSOA_SIS003_PESSOA_ID",
                        column: x => x.SIS003_PESSOA_ID,
                        principalTable: "SIS003_PESSOA",
                        principalColumn: "SIS003_PESSOA_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SIS002_EMPRESA_SIS001_TENANT_ID",
                table: "SIS002_EMPRESA",
                column: "SIS001_TENANT_ID");

            migrationBuilder.CreateIndex(
                name: "IX_SIS003_PESSOA_SIS001_TENANT_ID",
                table: "SIS003_PESSOA",
                column: "SIS001_TENANT_ID");

            migrationBuilder.CreateIndex(
                name: "IX_SIS003_PESSOA_SIS014_CONTATO_ID",
                table: "SIS003_PESSOA",
                column: "SIS014_CONTATO_ID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SIS004_EMPRESA_PESSOA_SIS002_EMPRESA_ID",
                table: "SIS004_EMPRESA_PESSOA",
                column: "SIS002_EMPRESA_ID");

            migrationBuilder.CreateIndex(
                name: "IX_SIS004_EMPRESA_PESSOA_SIS003_PESSOA_ID",
                table: "SIS004_EMPRESA_PESSOA",
                column: "SIS003_PESSOA_ID");

            migrationBuilder.CreateIndex(
                name: "IX_SIS005_USUARIO_SIS003_PESSOA_ID",
                table: "SIS005_USUARIO",
                column: "SIS003_PESSOA_ID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SIS005_USUARIO_SIS006_TIPO_USUARIO_ID",
                table: "SIS005_USUARIO",
                column: "SIS006_TIPO_USUARIO_ID");

            migrationBuilder.CreateIndex(
                name: "IX_SIS008_TENANT_PLANO_SIS001_TENANT_ID",
                table: "SIS008_TENANT_PLANO",
                column: "SIS001_TENANT_ID");

            migrationBuilder.CreateIndex(
                name: "IX_SIS008_TENANT_PLANO_SIS007_PLANO_ID",
                table: "SIS008_TENANT_PLANO",
                column: "SIS007_PLANO_ID");

            migrationBuilder.CreateIndex(
                name: "IX_SIS010_NODO_SERVICO_SIS009_SERVICO_ID",
                table: "SIS010_NODO_SERVICO",
                column: "SIS009_SERVICO_ID");

            migrationBuilder.CreateIndex(
                name: "IX_SIS012_CIDADE_SIS011_ESTADO_ID",
                table: "SIS012_CIDADE",
                column: "SIS011_ESTADO_ID");

            migrationBuilder.CreateIndex(
                name: "IX_SIS013_ENDERECO_SIS003_PESSOA_ID",
                table: "SIS013_ENDERECO",
                column: "SIS003_PESSOA_ID");

            migrationBuilder.CreateIndex(
                name: "IX_SIS013_ENDERECO_SIS012_CIDADE_ID",
                table: "SIS013_ENDERECO",
                column: "SIS012_CIDADE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_SIS013_ENDERECO_SIS019_TIPO_ENDERECO_ID",
                table: "SIS013_ENDERECO",
                column: "SIS019_TIPO_ENDERECO_ID");

            migrationBuilder.CreateIndex(
                name: "IX_SIS015_EMPRESA_IMAGEM_SIS002_EMPRESA_ID",
                table: "SIS015_EMPRESA_IMAGEM",
                column: "SIS002_EMPRESA_ID");

            migrationBuilder.CreateIndex(
                name: "IX_SIS016_PESSOA_IMAGEM_SIS003_PESSOA_ID",
                table: "SIS016_PESSOA_IMAGEM",
                column: "SIS003_PESSOA_ID");

            migrationBuilder.CreateIndex(
                name: "IX_SIS018_EMPRESA_CNAE_SIS002_EMPRESA_ID",
                table: "SIS018_EMPRESA_CNAE",
                column: "SIS002_EMPRESA_ID");

            migrationBuilder.CreateIndex(
                name: "IX_SIS018_EMPRESA_CNAE_SIS017_CNAE_ID",
                table: "SIS018_EMPRESA_CNAE",
                column: "SIS017_CNAE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_SIS021_PLANO_NODO_SERVICO_SIS007_PLANO_ID",
                table: "SIS021_PLANO_NODO_SERVICO",
                column: "SIS007_PLANO_ID");

            migrationBuilder.CreateIndex(
                name: "IX_SIS021_PLANO_NODO_SERVICO_SIS010_NODO_SERVICO_ID",
                table: "SIS021_PLANO_NODO_SERVICO",
                column: "SIS010_NODO_SERVICO_ID");

            migrationBuilder.CreateIndex(
                name: "IX_SIS022_EMPRESA_SEGMENTO_SIS002_EMPRESA_ID",
                table: "SIS022_EMPRESA_SEGMENTO",
                column: "SIS002_EMPRESA_ID");

            migrationBuilder.CreateIndex(
                name: "IX_SIS022_EMPRESA_SEGMENTO_SIS020_SEGMENTO_ID",
                table: "SIS022_EMPRESA_SEGMENTO",
                column: "SIS020_SEGMENTO_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_SIS002_EMPRESA_SIS013_ENDERECO_SIS002_EMPRESA_ID",
                table: "SIS002_EMPRESA",
                column: "SIS002_EMPRESA_ID",
                principalTable: "SIS013_ENDERECO",
                principalColumn: "SIS013_ENDERECO_ID",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SIS002_EMPRESA_SIS001_TENANT_SIS001_TENANT_ID",
                table: "SIS002_EMPRESA");

            migrationBuilder.DropForeignKey(
                name: "FK_SIS003_PESSOA_SIS001_TENANT_SIS001_TENANT_ID",
                table: "SIS003_PESSOA");

            migrationBuilder.DropForeignKey(
                name: "FK_SIS002_EMPRESA_SIS013_ENDERECO_SIS002_EMPRESA_ID",
                table: "SIS002_EMPRESA");

            migrationBuilder.DropTable(
                name: "SIS004_EMPRESA_PESSOA");

            migrationBuilder.DropTable(
                name: "SIS005_USUARIO");

            migrationBuilder.DropTable(
                name: "SIS008_TENANT_PLANO");

            migrationBuilder.DropTable(
                name: "SIS015_EMPRESA_IMAGEM");

            migrationBuilder.DropTable(
                name: "SIS016_PESSOA_IMAGEM");

            migrationBuilder.DropTable(
                name: "SIS018_EMPRESA_CNAE");

            migrationBuilder.DropTable(
                name: "SIS021_PLANO_NODO_SERVICO");

            migrationBuilder.DropTable(
                name: "SIS022_EMPRESA_SEGMENTO");

            migrationBuilder.DropTable(
                name: "SIS006_TIPO_USUARIO");

            migrationBuilder.DropTable(
                name: "SIS017_CNAE");

            migrationBuilder.DropTable(
                name: "SIS007_PLANO");

            migrationBuilder.DropTable(
                name: "SIS010_NODO_SERVICO");

            migrationBuilder.DropTable(
                name: "SIS020_SEGMENTO");

            migrationBuilder.DropTable(
                name: "SIS009_SERVICO");

            migrationBuilder.DropTable(
                name: "SIS001_TENANT");

            migrationBuilder.DropTable(
                name: "SIS013_ENDERECO");

            migrationBuilder.DropTable(
                name: "SIS003_PESSOA");

            migrationBuilder.DropTable(
                name: "SIS012_CIDADE");

            migrationBuilder.DropTable(
                name: "SIS019_TIPO_ENDERECO");

            migrationBuilder.DropTable(
                name: "SIS014_CONTATO");

            migrationBuilder.DropTable(
                name: "SIS011_ESTADO");

            migrationBuilder.DropTable(
                name: "SIS002_EMPRESA");
        }
    }
}
