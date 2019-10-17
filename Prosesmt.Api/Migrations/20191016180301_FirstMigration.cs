using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Prosesmt.Api.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CNPJ_CPF = table.Column<string>(type: "varchar(14)", nullable: false),
                    RazaoSocial_Nome = table.Column<string>(type: "varchar(60)", nullable: false),
                    CEP = table.Column<string>(type: "varchar(8)", nullable: false),
                    Logradouro = table.Column<string>(type: "varchar(60)", nullable: false),
                    Logradouro_Numero = table.Column<string>(type: "varchar(10)", nullable: false),
                    Logradouro_Complemento = table.Column<string>(type: "varchar(60)", nullable: false),
                    Logradouro_Bairro = table.Column<string>(type: "varchar(60)", nullable: false),
                    Logradouro_Cidade = table.Column<string>(type: "varchar(60)", nullable: false),
                    Logradouro_UF = table.Column<string>(type: "varchar(2)", nullable: false),
                    Telefone = table.Column<string>(type: "varchar(12)", nullable: true),
                    SLA_RespostaTempo = table.Column<int>(type: "int", nullable: false, defaultValue: 4)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Chamados",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ClienteId = table.Column<long>(nullable: true),
                    DataHora_Abertura = table.Column<DateTime>(type: "datetime", nullable: false),
                    Fechado = table.Column<bool>(type: "bit", nullable: false, defaultValue: 0),
                    DataHora_Fechamento = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chamados", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Chamados_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Chamados_ClienteId",
                table: "Chamados",
                column: "ClienteId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Chamados");

            migrationBuilder.DropTable(
                name: "Clientes");
        }
    }
}
