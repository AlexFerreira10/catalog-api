using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CatalogApi.Migrations
{
    /// <inheritdoc />
    public partial class PopulateProductTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql(@"INSERT INTO Product (Name, Description, Price, ImageUrl, Stock, RegisterDate, CategoryId) 
                     VALUES ('Refrigerante Coca-Cola', 'Coca-Cola lata 350ml', 5.99, 'coca-cola.jpg', 50, NOW(), 1)");
            
            mb.Sql(@"INSERT INTO Product (Name, Description, Price, ImageUrl, Stock, RegisterDate, CategoryId) 
                     VALUES ('Hambúrguer Artesanal', 'Hambúrguer com carne de angus', 25.90, 'hamburguer.jpg', 30, NOW(), 2)");
           
            mb.Sql(@"INSERT INTO Product (Name, Description, Price, ImageUrl, Stock, RegisterDate, CategoryId) 
                     VALUES ('Pudim de Leite', 'Delicioso pudim de leite condensado', 12.50, 'pudim.jpg', 20, NOW(), 3)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder mb)
        {
             mb.Sql("DELETE FROM Product WHERE Name IN ('Refrigerante Coca-Cola', 'Hambúrguer Artesanal', 'Pudim de Leite')");
        }
    }
}
