using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimalShelterApi.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pets",
                columns: table => new
                {
                    PetId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Species = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Color = table.Column<string>(nullable: true),
                    Age = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pets", x => x.PetId);
                });

            migrationBuilder.InsertData(
                table: "Pets",
                columns: new[] { "PetId", "Age", "Color", "Name", "Species" },
                values: new object[,]
                {
                    { 1, "7", "black", "Fred", "Cat" },
                    { 2, "3", "white", "Chubs", "Cat" },
                    { 3, "5", "black/white", "Teddy", "Dog" },
                    { 4, "10", "tan", "Billy", "Cat" },
                    { 5, "3", "black/white", "Snoopy", "Dog" },
                    { 6, "6", "brown", "Bear", "Dog" },
                    { 7, "11", "gray", "Hulk", "Dog" },
                    { 8, "12", "black", "Medusa", "Cat" },
                    { 9, "7", "black/brown", "Hercules", "Dog" },
                    { 10, "9", "gray", "Pythagrous", "Cat" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pets");
        }
    }
}
