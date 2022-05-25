using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SiteVente.Migrations
{
    public partial class initDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    Nom = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TypeClient = table.Column<int>(type: "int", nullable: false),
                    Adresse = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.Nom);
                });

            migrationBuilder.CreateTable(
                name: "Produit",
                columns: table => new
                {
                    Nom = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    Quantite = table.Column<int>(type: "int", nullable: true),
                    Marque = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produit", x => x.Nom);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Client");

            migrationBuilder.DropTable(
                name: "Produit");
        }
    }
}
