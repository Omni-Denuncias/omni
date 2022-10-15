using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace omni.Migrations
{
    public partial class Classesss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cidadaos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Celular = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sobrenome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cep = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TituloEleitor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ZonaEleitoral = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Secao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PontuacaoCidadao = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cidadaos", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 177, 150, 103, 135, 220, 132, 115, 13, 197, 197, 178, 56, 108, 12, 41, 228, 104, 168, 96, 44, 135, 56, 111, 188, 118, 213, 205, 61, 54, 49, 17, 181, 31, 215, 32, 205, 113, 139, 63, 108, 243, 78, 200, 176, 104, 247, 161, 121, 162, 62, 201, 93, 19, 101, 109, 23, 34, 161, 140, 245, 121, 31, 219, 231 }, new byte[] { 153, 24, 112, 82, 191, 67, 199, 88, 126, 98, 226, 94, 191, 92, 20, 100, 47, 53, 194, 161, 164, 238, 80, 86, 37, 39, 113, 249, 8, 60, 177, 221, 203, 143, 186, 90, 95, 153, 109, 227, 132, 54, 125, 247, 23, 181, 16, 106, 207, 101, 254, 77, 73, 23, 73, 142, 170, 174, 37, 59, 79, 230, 205, 109, 20, 109, 106, 247, 133, 202, 35, 35, 177, 32, 185, 182, 28, 255, 236, 59, 96, 125, 6, 205, 46, 67, 125, 63, 203, 230, 160, 19, 121, 179, 0, 180, 66, 169, 17, 70, 228, 220, 62, 45, 100, 19, 26, 32, 218, 143, 177, 20, 247, 14, 243, 145, 137, 98, 248, 203, 217, 212, 62, 245, 50, 160, 76, 2 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cidadaos");

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 195, 5, 169, 167, 178, 119, 27, 7, 254, 42, 224, 169, 129, 140, 94, 191, 189, 167, 215, 11, 92, 28, 136, 149, 146, 62, 216, 180, 36, 226, 81, 61, 246, 157, 67, 102, 0, 66, 134, 2, 114, 234, 224, 242, 230, 74, 109, 63, 63, 90, 101, 50, 53, 144, 138, 131, 123, 246, 129, 242, 134, 253, 243, 147 }, new byte[] { 129, 149, 249, 52, 222, 176, 61, 207, 80, 21, 204, 41, 94, 79, 91, 72, 224, 223, 143, 22, 135, 0, 228, 150, 211, 158, 242, 146, 239, 59, 88, 165, 62, 32, 66, 163, 94, 157, 193, 193, 251, 166, 228, 29, 151, 25, 16, 137, 81, 172, 143, 117, 233, 106, 167, 90, 101, 234, 24, 145, 236, 182, 66, 241, 77, 190, 32, 64, 110, 225, 18, 149, 48, 205, 64, 114, 49, 8, 134, 26, 21, 1, 222, 82, 77, 183, 18, 216, 61, 80, 225, 136, 186, 247, 223, 175, 99, 74, 39, 28, 210, 137, 63, 91, 192, 137, 127, 202, 110, 160, 177, 235, 226, 254, 4, 189, 207, 60, 8, 58, 90, 60, 105, 244, 234, 202, 223, 42 } });
        }
    }
}
