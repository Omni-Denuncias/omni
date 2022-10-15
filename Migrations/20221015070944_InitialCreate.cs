using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace omni.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Foto = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Latitude = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Longitude = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "Email", "Foto", "Latitude", "Longitude", "PasswordHash", "PasswordSalt", "Username" },
                values: new object[] { 1, null, null, null, null, new byte[] { 8, 18, 109, 187, 42, 106, 142, 251, 110, 107, 218, 250, 121, 73, 137, 35, 198, 193, 44, 188, 206, 240, 14, 198, 96, 1, 234, 96, 195, 9, 230, 193, 171, 86, 215, 208, 208, 15, 131, 125, 138, 218, 208, 189, 68, 114, 243, 251, 72, 151, 161, 155, 13, 130, 201, 108, 61, 116, 59, 233, 201, 71, 112, 177 }, new byte[] { 157, 202, 207, 101, 64, 63, 10, 161, 150, 63, 87, 161, 148, 83, 46, 128, 214, 212, 255, 178, 36, 185, 146, 147, 152, 22, 121, 112, 220, 43, 21, 183, 243, 92, 48, 161, 3, 221, 252, 178, 112, 1, 33, 47, 20, 235, 98, 207, 243, 222, 12, 233, 73, 192, 123, 165, 14, 250, 24, 50, 159, 189, 244, 11, 157, 74, 213, 58, 239, 59, 134, 212, 249, 174, 164, 61, 36, 186, 154, 3, 45, 115, 50, 211, 73, 89, 239, 196, 231, 168, 238, 47, 227, 213, 213, 230, 247, 59, 131, 79, 36, 233, 71, 238, 229, 3, 141, 206, 238, 122, 0, 206, 245, 158, 99, 198, 7, 49, 38, 218, 151, 90, 238, 116, 0, 91, 174, 69 }, "UsuarioAdmin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
