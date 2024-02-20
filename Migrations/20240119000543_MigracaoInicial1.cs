using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanchesMac.Migrations
{
    public partial class MigracaoInicial1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lanches_Categorias_CategoriaId",
                table: "Lanches");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Lanches",
                table: "Lanches");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categorias",
                table: "Categorias");

            migrationBuilder.RenameTable(
                name: "Lanches",
                newName: "LANCHES");

            migrationBuilder.RenameTable(
                name: "Categorias",
                newName: "CATEGORIAS");

            migrationBuilder.RenameIndex(
                name: "IX_Lanches_CategoriaId",
                table: "LANCHES",
                newName: "IX_LANCHES_CategoriaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LANCHES",
                table: "LANCHES",
                column: "LancheId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CATEGORIAS",
                table: "CATEGORIAS",
                column: "CategoriaId");

            migrationBuilder.AddForeignKey(
                name: "FK_LANCHES_CATEGORIAS_CategoriaId",
                table: "LANCHES",
                column: "CategoriaId",
                principalTable: "CATEGORIAS",
                principalColumn: "CategoriaId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LANCHES_CATEGORIAS_CategoriaId",
                table: "LANCHES");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LANCHES",
                table: "LANCHES");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CATEGORIAS",
                table: "CATEGORIAS");

            migrationBuilder.RenameTable(
                name: "LANCHES",
                newName: "Lanches");

            migrationBuilder.RenameTable(
                name: "CATEGORIAS",
                newName: "Categorias");

            migrationBuilder.RenameIndex(
                name: "IX_LANCHES_CategoriaId",
                table: "Lanches",
                newName: "IX_Lanches_CategoriaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Lanches",
                table: "Lanches",
                column: "LancheId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categorias",
                table: "Categorias",
                column: "CategoriaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Lanches_Categorias_CategoriaId",
                table: "Lanches",
                column: "CategoriaId",
                principalTable: "Categorias",
                principalColumn: "CategoriaId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
