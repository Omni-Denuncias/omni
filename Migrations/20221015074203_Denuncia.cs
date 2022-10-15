using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace omni.Migrations
{
    public partial class Denuncia : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Cidadaos",
                newName: "IdCidadao");

            migrationBuilder.CreateTable(
                name: "Apontamentos",
                columns: table => new
                {
                    IdApontamento = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdDenuncia = table.Column<int>(type: "int", nullable: false),
                    MomentoApontamento = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DescricaoApontamento = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Apontamentos", x => x.IdApontamento);
                });

            migrationBuilder.CreateTable(
                name: "Denuncias",
                columns: table => new
                {
                    IdDenuncia = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdCidadao = table.Column<int>(type: "int", nullable: false),
                    IdTipoDenuncia = table.Column<int>(type: "int", nullable: false),
                    IdStatus = table.Column<int>(type: "int", nullable: false),
                    DataDenuncia = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DescricaoDenuncia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LocalDenuncia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PontosPrioridade = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Denuncias", x => x.IdDenuncia);
                });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 226, 20, 27, 224, 36, 59, 53, 211, 181, 139, 153, 202, 72, 25, 53, 215, 173, 186, 32, 244, 88, 121, 202, 41, 166, 125, 44, 221, 54, 76, 144, 16, 172, 3, 57, 88, 48, 71, 149, 218, 39, 127, 196, 81, 166, 104, 148, 123, 110, 34, 229, 248, 7, 75, 127, 113, 22, 51, 11, 10, 112, 32, 24, 1 }, new byte[] { 131, 109, 75, 157, 174, 182, 190, 5, 41, 65, 208, 146, 231, 166, 131, 59, 46, 5, 111, 197, 140, 221, 101, 83, 124, 68, 220, 185, 203, 166, 89, 190, 120, 105, 135, 136, 31, 137, 1, 206, 105, 246, 235, 100, 59, 68, 126, 136, 15, 117, 161, 137, 161, 140, 187, 15, 113, 20, 222, 47, 194, 162, 75, 24, 89, 20, 0, 111, 51, 237, 223, 253, 225, 152, 221, 172, 165, 159, 113, 159, 120, 95, 241, 247, 240, 75, 40, 167, 109, 180, 60, 17, 150, 127, 25, 102, 118, 49, 110, 77, 70, 65, 168, 242, 13, 88, 82, 112, 229, 254, 84, 193, 201, 35, 106, 131, 218, 164, 195, 60, 39, 137, 46, 250, 95, 210, 113, 7 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Apontamentos");

            migrationBuilder.DropTable(
                name: "Denuncias");

            migrationBuilder.RenameColumn(
                name: "IdCidadao",
                table: "Cidadaos",
                newName: "Id");

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 177, 150, 103, 135, 220, 132, 115, 13, 197, 197, 178, 56, 108, 12, 41, 228, 104, 168, 96, 44, 135, 56, 111, 188, 118, 213, 205, 61, 54, 49, 17, 181, 31, 215, 32, 205, 113, 139, 63, 108, 243, 78, 200, 176, 104, 247, 161, 121, 162, 62, 201, 93, 19, 101, 109, 23, 34, 161, 140, 245, 121, 31, 219, 231 }, new byte[] { 153, 24, 112, 82, 191, 67, 199, 88, 126, 98, 226, 94, 191, 92, 20, 100, 47, 53, 194, 161, 164, 238, 80, 86, 37, 39, 113, 249, 8, 60, 177, 221, 203, 143, 186, 90, 95, 153, 109, 227, 132, 54, 125, 247, 23, 181, 16, 106, 207, 101, 254, 77, 73, 23, 73, 142, 170, 174, 37, 59, 79, 230, 205, 109, 20, 109, 106, 247, 133, 202, 35, 35, 177, 32, 185, 182, 28, 255, 236, 59, 96, 125, 6, 205, 46, 67, 125, 63, 203, 230, 160, 19, 121, 179, 0, 180, 66, 169, 17, 70, 228, 220, 62, 45, 100, 19, 26, 32, 218, 143, 177, 20, 247, 14, 243, 145, 137, 98, 248, 203, 217, 212, 62, 245, 50, 160, 76, 2 } });
        }
    }
}
