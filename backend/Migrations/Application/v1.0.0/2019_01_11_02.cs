using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Persistencia.Contexts.Application;

namespace Migrations
{
    [Migration("2019011102")]
    [DbContext(typeof(ApplicationDbContext))]
    public class Conversor_2019011102 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("create table Fornecedor (" +
                "id bigint not null," +
                "nome varchar(30) not null," +
                "endereco varchar(30) not null," +
                "estado varchar(30) not null," +
                "primary key(id))"
                );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
        }
    }
}
