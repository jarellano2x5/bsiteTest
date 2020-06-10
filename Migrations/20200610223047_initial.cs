using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace bsiteTest.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Costumers",
                columns: table => new
                {
                    CostumerID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameStyle = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
                    Title = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
                    FirstName = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    MiddleName = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    LastName = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    Suffix = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    CompanyName = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    SalesPerson = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    EmailAddress = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    Phone = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
                    PasswordHash = table.Column<string>(unicode: false, maxLength: 12, nullable: false),
                    PasswordSalt = table.Column<string>(unicode: false, maxLength: 12, nullable: false),
                    rowguid = table.Column<Guid>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Costumers", x => x.CostumerID);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(unicode: false, maxLength: 30, nullable: false),
                    ProductNumber = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
                    Color = table.Column<string>(unicode: false, maxLength: 30, nullable: false),
                    StandardCost = table.Column<decimal>(nullable: false),
                    ListPrice = table.Column<decimal>(nullable: false),
                    Size = table.Column<decimal>(nullable: false),
                    Weight = table.Column<decimal>(nullable: false),
                    ProductCategoryID = table.Column<int>(nullable: false),
                    ProductModelID = table.Column<int>(nullable: false),
                    SellStartDate = table.Column<DateTime>(nullable: false),
                    SellEndDate = table.Column<DateTime>(nullable: false),
                    DiscontinuedDate = table.Column<DateTime>(nullable: false),
                    ThumbNailPhoto = table.Column<byte[]>(nullable: true),
                    ThumbNailPhotoFileName = table.Column<string>(unicode: false, maxLength: 80, nullable: false),
                    rowguid = table.Column<Guid>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Costumers");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
