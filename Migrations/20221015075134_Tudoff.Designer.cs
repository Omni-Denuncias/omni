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
    [Migration("20221015075134_Tudoff")]
    partial class Tudoff
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
                            PasswordHash = new byte[] { 78, 178, 19, 141, 139, 149, 186, 148, 86, 136, 132, 30, 223, 225, 112, 56, 84, 13, 13, 239, 225, 151, 96, 85, 120, 74, 219, 170, 10, 179, 3, 106, 104, 190, 216, 254, 141, 175, 143, 202, 251, 139, 203, 225, 135, 188, 146, 80, 116, 172, 200, 240, 206, 108, 32, 104, 199, 173, 89, 56, 112, 108, 54, 184 },
                            PasswordSalt = new byte[] { 210, 162, 69, 137, 89, 96, 13, 110, 161, 119, 59, 37, 37, 131, 16, 86, 74, 37, 58, 243, 31, 79, 244, 151, 181, 163, 7, 78, 94, 245, 213, 182, 15, 142, 104, 125, 67, 151, 198, 78, 51, 176, 96, 208, 210, 170, 132, 225, 176, 122, 47, 109, 202, 41, 49, 209, 25, 177, 201, 181, 67, 191, 7, 203, 15, 82, 137, 208, 212, 2, 60, 15, 90, 93, 55, 112, 170, 188, 27, 8, 242, 74, 238, 142, 25, 253, 124, 145, 160, 87, 191, 192, 38, 146, 208, 16, 243, 235, 76, 169, 206, 125, 53, 110, 85, 62, 6, 238, 25, 253, 187, 122, 14, 111, 187, 22, 26, 20, 2, 167, 145, 24, 36, 224, 224, 3, 120, 214 },
                            Username = "UsuarioAdmin"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}