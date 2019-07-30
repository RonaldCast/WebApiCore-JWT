using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApi.Migrations
{
    public partial class migracionInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pais",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Nombre = table.Column<string>(maxLength: 50, nullable: false),
                    Habitantes = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pais", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Pais",
                columns: new[] { "Id", "Habitantes", "Nombre" },
                values: new object[,]
                {
                    { new Guid("89d1b095-f34c-4341-bcab-599330589826"), 46000000, "España" },
                    { new Guid("2354ded8-148e-4a16-b391-c2011de35ad0"), 468200000, "Alemania" },
                    { new Guid("79ab5086-0556-4800-ab20-6f83763ebe54"), 1500000, "Francia" },
                    { new Guid("47f4e525-db5a-49bc-8452-3fbdf61e2cc8"), 62820000, "Italia" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pais");
        }
    }
}
