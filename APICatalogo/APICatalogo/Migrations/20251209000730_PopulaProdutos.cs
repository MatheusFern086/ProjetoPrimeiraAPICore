using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APICatalogo.Migrations
{
    /// <inheritdoc />
    public partial class PopulaProdutos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("INSERT INTO Produtos(Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) " +
                "VALUES ('Coca-Cola Zero', 'Refrigerante sabor cola 350ml', 4.99, 'coca_cola.jpg', 50, GETDATE(), 1)");

            mb.Sql("INSERT INTO Produtos(Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) " +
                "VALUES ('Lanche de Atum', 'Lanche de Atum com maionese', 8.50, 'atum.jpg', 10, GETDATE(), 2)");

            mb.Sql("INSERT INTO Produtos(Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) " +
               "VALUES ('Pudim 100g', 'Pudim de leite condesado 100g', 6.75, 'pudim.jpg', 20, GETDATE(), 3)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("DELETE FROM Produtos");
        }
    }
}
