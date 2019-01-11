using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistencia.Migrations
{
    [Migration("20190107231600")]
    [DbContext(typeof(DataBaseContext))]
    public class test : Migration
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
