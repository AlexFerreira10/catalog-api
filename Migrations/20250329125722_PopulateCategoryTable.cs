using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CatalogApi.Migrations
{
    /// <inheritdoc />
    public partial class PopulateCategoryTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("Insert into Categories(Nome, ImageUrl) Values('Bebidas', 'bebidas.jpg')");
            mb.Sql("Insert into Categories(Nome, ImageUrl) Values('Lanches', 'lanches.jpg')");
            mb.Sql("Insert into Categories(Nome, ImageUrl) Values('Sobremesas', 'sobremesas.jpg')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("Delete from Categories");
        }
    }
}
