using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanchesMAC_WEB_APP_.Migrations
{
    public partial class PopularCategorias : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Categorias(NomeCategoria, Descricao) VALUES ('Normal','Lanche com ingredientes normais.')");
            migrationBuilder.Sql("INSERT INTO Categorias(NomeCategoria, Descricao) VALUES ('Natural','Lanche com ingredientes naturais.')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Categorias");
        }
    }
}
