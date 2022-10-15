using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore.Scaffolding;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Update;
using Microsoft.EntityFrameworkCore.ValueGeneration;
using omni.Models;
using omni.Utils;
using System;

namespace RpgApi.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Cidadao> Cidadaos { get; set; }
        public DbSet<Apontamentos> Apontamentos { get; set; }
        public DbSet<Denuncia> Denuncias { get; set; }
        public DbSet<FotoCidadao> FotoCidadaos { get; set; }
        public DbSet<ImagemDenuncia> ImagemDenuncias { get; set; }
        public DbSet<ImagemPublicacao> ImagemPublicacaos { get; set; }
        public DbSet<Publicacoes> Publicacoes { get; set; }
        public DbSet<StatusDenuncia> StatusDenuncias { get; set; }
        public DbSet<TipoPublicacao> TipoPublicacaos { get; set; }
        public DbSet<TiposDenuncia> TiposDenuncias { get; set; }

        // Durante a criação do modelo de banco de dados, os seguintes dados são adicionados
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //Inicio da criação do usuário padrão
            Usuario user = new Usuario();
            Criptografia.CriarPasswordHash("123456", out byte[] hash, out byte[] salt);
            user.Id= 1;
            user.Username = "UsuarioAdmin";
            user.PasswordString = "string.Empty";
            user.PasswordHash = hash;
            user.PasswordSalt = salt;

            modelBuilder.Entity<Usuario>().HasData(user);
            //Fim da criação do usuário padrão
        }
    }

}