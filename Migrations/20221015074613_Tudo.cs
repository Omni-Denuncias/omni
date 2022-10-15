using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace omni.Migrations
{
    public partial class Tudo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FotoCidadaos",
                columns: table => new
                {
                    IdCidadao = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VbFotoCidadao = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FotoCidadaos", x => x.IdCidadao);
                });

            migrationBuilder.CreateTable(
                name: "ImagemDenuncias",
                columns: table => new
                {
                    IdImagemDenuncia = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdDenuncia = table.Column<int>(type: "int", nullable: false),
                    VbImagemDenuncia = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImagemDenuncias", x => x.IdImagemDenuncia);
                });

            migrationBuilder.CreateTable(
                name: "ImagemPublicacaos",
                columns: table => new
                {
                    IdPublicacaoImagem = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdPublicacao = table.Column<int>(type: "int", nullable: false),
                    VbPublicacaoImagem = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImagemPublicacaos", x => x.IdPublicacaoImagem);
                });

            migrationBuilder.CreateTable(
                name: "Publicacoes",
                columns: table => new
                {
                    IdPublicacao = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdTipoPublicacao = table.Column<int>(type: "int", nullable: false),
                    TextoPublicacao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LinkPublicacao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataInicioExibicao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataFimExibicao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SensibilidadePublicacao = table.Column<int>(type: "int", nullable: false),
                    PrioridadePublicacao = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publicacoes", x => x.IdPublicacao);
                });

            migrationBuilder.CreateTable(
                name: "StatusDenuncias",
                columns: table => new
                {
                    IdStatus = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescricaoStatus = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatusDenuncias", x => x.IdStatus);
                });

            migrationBuilder.CreateTable(
                name: "TipoPublicacaos",
                columns: table => new
                {
                    IdTipoPublicacao = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescricaoTipoPublicacao = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoPublicacaos", x => x.IdTipoPublicacao);
                });

            migrationBuilder.CreateTable(
                name: "TiposDenuncias",
                columns: table => new
                {
                    IdTipoDenuncia = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescricaoTipoDenuncia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PontuacaoTipoDenuncia = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposDenuncias", x => x.IdTipoDenuncia);
                });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 221, 106, 43, 63, 17, 220, 177, 167, 253, 165, 103, 18, 120, 239, 34, 122, 159, 192, 234, 33, 199, 184, 32, 90, 181, 18, 15, 66, 226, 92, 69, 184, 55, 29, 5, 206, 70, 231, 62, 152, 88, 170, 247, 211, 45, 215, 32, 69, 8, 156, 33, 171, 210, 115, 6, 26, 105, 198, 104, 34, 59, 71, 86, 106 }, new byte[] { 98, 113, 148, 70, 144, 136, 152, 3, 70, 177, 44, 207, 50, 217, 175, 247, 148, 68, 117, 182, 166, 233, 85, 31, 245, 218, 177, 13, 55, 21, 6, 33, 77, 76, 73, 48, 67, 196, 207, 36, 205, 131, 88, 63, 71, 51, 212, 251, 234, 237, 47, 242, 151, 146, 137, 168, 210, 101, 204, 181, 78, 67, 81, 150, 237, 110, 80, 85, 86, 225, 249, 21, 78, 173, 58, 235, 160, 197, 219, 30, 132, 231, 94, 105, 0, 3, 135, 88, 98, 187, 61, 188, 200, 33, 111, 22, 111, 116, 217, 195, 210, 224, 7, 149, 140, 210, 80, 172, 230, 51, 179, 69, 109, 95, 40, 238, 184, 210, 204, 2, 219, 242, 215, 55, 247, 80, 90, 141 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FotoCidadaos");

            migrationBuilder.DropTable(
                name: "ImagemDenuncias");

            migrationBuilder.DropTable(
                name: "ImagemPublicacaos");

            migrationBuilder.DropTable(
                name: "Publicacoes");

            migrationBuilder.DropTable(
                name: "StatusDenuncias");

            migrationBuilder.DropTable(
                name: "TipoPublicacaos");

            migrationBuilder.DropTable(
                name: "TiposDenuncias");

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 226, 20, 27, 224, 36, 59, 53, 211, 181, 139, 153, 202, 72, 25, 53, 215, 173, 186, 32, 244, 88, 121, 202, 41, 166, 125, 44, 221, 54, 76, 144, 16, 172, 3, 57, 88, 48, 71, 149, 218, 39, 127, 196, 81, 166, 104, 148, 123, 110, 34, 229, 248, 7, 75, 127, 113, 22, 51, 11, 10, 112, 32, 24, 1 }, new byte[] { 131, 109, 75, 157, 174, 182, 190, 5, 41, 65, 208, 146, 231, 166, 131, 59, 46, 5, 111, 197, 140, 221, 101, 83, 124, 68, 220, 185, 203, 166, 89, 190, 120, 105, 135, 136, 31, 137, 1, 206, 105, 246, 235, 100, 59, 68, 126, 136, 15, 117, 161, 137, 161, 140, 187, 15, 113, 20, 222, 47, 194, 162, 75, 24, 89, 20, 0, 111, 51, 237, 223, 253, 225, 152, 221, 172, 165, 159, 113, 159, 120, 95, 241, 247, 240, 75, 40, 167, 109, 180, 60, 17, 150, 127, 25, 102, 118, 49, 110, 77, 70, 65, 168, 242, 13, 88, 82, 112, 229, 254, 84, 193, 201, 35, 106, 131, 218, 164, 195, 60, 39, 137, 46, 250, 95, 210, 113, 7 } });
        }
    }
}
