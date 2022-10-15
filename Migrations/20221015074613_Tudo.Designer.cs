﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RpgApi.Data;

namespace omni.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20221015074613_Tudo")]
    partial class Tudo
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.15")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("omni.Models.Apontamentos", b =>
                {
                    b.Property<int>("IdApontamento")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DescricaoApontamento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdDenuncia")
                        .HasColumnType("int");

                    b.Property<DateTime?>("MomentoApontamento")
                        .HasColumnType("datetime2");

                    b.HasKey("IdApontamento");

                    b.ToTable("Apontamentos");
                });

            modelBuilder.Entity("omni.Models.Cidadao", b =>
                {
                    b.Property<int>("IdCidadao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Celular")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cep")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PontuacaoCidadao")
                        .HasColumnType("int");

                    b.Property<string>("Secao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sobrenome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TituloEleitor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ZonaEleitoral")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdCidadao");

                    b.ToTable("Cidadaos");
                });

            modelBuilder.Entity("omni.Models.Denuncia", b =>
                {
                    b.Property<int>("IdDenuncia")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("DataDenuncia")
                        .HasColumnType("datetime2");

                    b.Property<string>("DescricaoDenuncia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdCidadao")
                        .HasColumnType("int");

                    b.Property<int>("IdStatus")
                        .HasColumnType("int");

                    b.Property<int>("IdTipoDenuncia")
                        .HasColumnType("int");

                    b.Property<string>("LocalDenuncia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PontosPrioridade")
                        .HasColumnType("int");

                    b.HasKey("IdDenuncia");

                    b.ToTable("Denuncias");
                });

            modelBuilder.Entity("omni.Models.FotoCidadao", b =>
                {
                    b.Property<int>("IdCidadao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte[]>("VbFotoCidadao")
                        .HasColumnType("varbinary(max)");

                    b.HasKey("IdCidadao");

                    b.ToTable("FotoCidadaos");
                });

            modelBuilder.Entity("omni.Models.ImagemDenuncia", b =>
                {
                    b.Property<int>("IdImagemDenuncia")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdDenuncia")
                        .HasColumnType("int");

                    b.Property<byte[]>("VbImagemDenuncia")
                        .HasColumnType("varbinary(max)");

                    b.HasKey("IdImagemDenuncia");

                    b.ToTable("ImagemDenuncias");
                });

            modelBuilder.Entity("omni.Models.ImagemPublicacao", b =>
                {
                    b.Property<int>("IdPublicacaoImagem")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdPublicacao")
                        .HasColumnType("int");

                    b.Property<byte[]>("VbPublicacaoImagem")
                        .HasColumnType("varbinary(max)");

                    b.HasKey("IdPublicacaoImagem");

                    b.ToTable("ImagemPublicacaos");
                });

            modelBuilder.Entity("omni.Models.Publicacoes", b =>
                {
                    b.Property<int>("IdPublicacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("DataFimExibicao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DataInicioExibicao")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdTipoPublicacao")
                        .HasColumnType("int");

                    b.Property<string>("LinkPublicacao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PrioridadePublicacao")
                        .HasColumnType("int");

                    b.Property<int>("SensibilidadePublicacao")
                        .HasColumnType("int");

                    b.Property<string>("TextoPublicacao")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdPublicacao");

                    b.ToTable("Publicacoes");
                });

            modelBuilder.Entity("omni.Models.StatusDenuncia", b =>
                {
                    b.Property<int>("IdStatus")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DescricaoStatus")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdStatus");

                    b.ToTable("StatusDenuncias");
                });

            modelBuilder.Entity("omni.Models.TipoPublicacao", b =>
                {
                    b.Property<int>("IdTipoPublicacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DescricaoTipoPublicacao")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdTipoPublicacao");

                    b.ToTable("TipoPublicacaos");
                });

            modelBuilder.Entity("omni.Models.TiposDenuncia", b =>
                {
                    b.Property<int>("IdTipoDenuncia")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DescricaoTipoDenuncia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PontuacaoTipoDenuncia")
                        .HasColumnType("int");

                    b.HasKey("IdTipoDenuncia");

                    b.ToTable("TiposDenuncias");
                });

            modelBuilder.Entity("omni.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Foto")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Latitude")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Longitude")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("PasswordHash")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            PasswordHash = new byte[] { 221, 106, 43, 63, 17, 220, 177, 167, 253, 165, 103, 18, 120, 239, 34, 122, 159, 192, 234, 33, 199, 184, 32, 90, 181, 18, 15, 66, 226, 92, 69, 184, 55, 29, 5, 206, 70, 231, 62, 152, 88, 170, 247, 211, 45, 215, 32, 69, 8, 156, 33, 171, 210, 115, 6, 26, 105, 198, 104, 34, 59, 71, 86, 106 },
                            PasswordSalt = new byte[] { 98, 113, 148, 70, 144, 136, 152, 3, 70, 177, 44, 207, 50, 217, 175, 247, 148, 68, 117, 182, 166, 233, 85, 31, 245, 218, 177, 13, 55, 21, 6, 33, 77, 76, 73, 48, 67, 196, 207, 36, 205, 131, 88, 63, 71, 51, 212, 251, 234, 237, 47, 242, 151, 146, 137, 168, 210, 101, 204, 181, 78, 67, 81, 150, 237, 110, 80, 85, 86, 225, 249, 21, 78, 173, 58, 235, 160, 197, 219, 30, 132, 231, 94, 105, 0, 3, 135, 88, 98, 187, 61, 188, 200, 33, 111, 22, 111, 116, 217, 195, 210, 224, 7, 149, 140, 210, 80, 172, 230, 51, 179, 69, 109, 95, 40, 238, 184, 210, 204, 2, 219, 242, 215, 55, 247, 80, 90, 141 },
                            Username = "UsuarioAdmin"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
