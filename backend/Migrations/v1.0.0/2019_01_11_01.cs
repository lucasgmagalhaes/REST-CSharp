using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Persistencia;

namespace Migrations
{
    [Migration("2019011101")]
    [DbContext(typeof(ApplicationDbContext))]
    public class Conversor_2019011101 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn("Teste", "Usuario");
            migrationBuilder.AddColumn<string>(name: "Teste", table: "Usuario", nullable: true, maxLength: 30, fixedLength: true, type: "varchar");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
