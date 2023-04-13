using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infraestructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // migrationBuilder.CreateTable(
            //     name: "Categoria",
            //     columns: table => new
            //     {
            //         Id = table.Column<int>(type: "int", nullable: false)
            //             .Annotation("SqlServer:Identity", "1, 1"),
            //         Nombre = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK__Categori__3214EC07132E4310", x => x.Id);
            //     });

            // migrationBuilder.CreateTable(
            //     name: "Marca",
            //     columns: table => new
            //     {
            //         Id = table.Column<int>(type: "int", nullable: false)
            //             .Annotation("SqlServer:Identity", "1, 1"),
            //         Nombre = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK__Marca__3214EC076D061926", x => x.Id);
            //     });

            // migrationBuilder.CreateTable(
            //     name: "Producto",
            //     columns: table => new
            //     {
            //         Id = table.Column<int>(type: "int", nullable: false)
            //             .Annotation("SqlServer:Identity", "1, 1"),
            //         Nombre = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
            //         Precio = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
            //         FechaCreacion = table.Column<DateTime>(type: "datetime", nullable: false),
            //         CategoriaId = table.Column<int>(type: "int", nullable: false, defaultValueSql: "('0')"),
            //         MarcaId = table.Column<int>(type: "int", nullable: false, defaultValueSql: "('0')")
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK__Producto__3214EC07C7450B06", x => x.Id);
            //         table.ForeignKey(
            //             name: "FK_Producto_Categoria_CategoriaId",
            //             column: x => x.CategoriaId,
            //             principalTable: "Categoria",
            //             principalColumn: "Id",
            //             onDelete: ReferentialAction.Cascade);
            //         table.ForeignKey(
            //             name: "FK_Producto_Marca_MarcaId",
            //             column: x => x.MarcaId,
            //             principalTable: "Marca",
            //             principalColumn: "Id",
            //             onDelete: ReferentialAction.Cascade);
            //     });

            // migrationBuilder.CreateIndex(
            //     name: "IX_Producto_CategoriaId",
            //     table: "Producto",
            //     column: "CategoriaId");

            // migrationBuilder.CreateIndex(
            //     name: "IX_Producto_MarcaId",
            //     table: "Producto",
            //     column: "MarcaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // migrationBuilder.DropTable(
            //     name: "Producto");

            // migrationBuilder.DropTable(
            //     name: "Categoria");

            // migrationBuilder.DropTable(
            //     name: "Marca");
        }
    }
}
