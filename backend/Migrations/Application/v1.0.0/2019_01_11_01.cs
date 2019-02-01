using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Persistencia.Contexts.Application;
using System;

namespace Migrations
{
    [Migration("2019011101")]
    [DbContext(typeof(ApplicationDbContext))]
    public class Conversor_2019011101 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn("Teste", "Usuario");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
        }
    }
}
