using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ProjectRasmusProgIII.Migrations
{
    public partial class First : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    CustomerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CustomerAddress = table.Column<string>(nullable: false),
                    CustomerCity = table.Column<string>(nullable: false),
                    CustomerCountry = table.Column<string>(nullable: false),
                    CustomerFirstName = table.Column<string>(maxLength: 50, nullable: false),
                    CustomerLastName = table.Column<string>(maxLength: 50, nullable: false),
                    CustomerPhone = table.Column<int>(nullable: false),
                    CustomerZipCode = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ProductCategory = table.Column<string>(nullable: false),
                    ProductImagePath = table.Column<string>(maxLength: 50, nullable: false),
                    ProductName = table.Column<string>(nullable: false),
                    ProductPrice = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "ShopOrder",
                columns: table => new
                {
                    ShopOrderId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CustomerId = table.Column<int>(nullable: false),
                    ShopOrderCreatedDate = table.Column<DateTime>(nullable: false),
                    ShopOrderPrice = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShopOrder", x => x.ShopOrderId);
                    table.ForeignKey(
                        name: "FK_ShopOrder_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderContent",
                columns: table => new
                {
                    OrderContentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    OrderContentPrice = table.Column<double>(nullable: false),
                    OrderContentQuantity = table.Column<int>(nullable: false),
                    ProductId = table.Column<int>(nullable: false),
                    ShopOrderId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderContent", x => x.OrderContentId);
                    table.ForeignKey(
                        name: "FK_OrderContent_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderContent_ShopOrder_ShopOrderId",
                        column: x => x.ShopOrderId,
                        principalTable: "ShopOrder",
                        principalColumn: "ShopOrderId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderContent_ProductId",
                table: "OrderContent",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderContent_ShopOrderId",
                table: "OrderContent",
                column: "ShopOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_ShopOrder_CustomerId",
                table: "ShopOrder",
                column: "CustomerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderContent");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "ShopOrder");

            migrationBuilder.DropTable(
                name: "Customer");
        }
    }
}
