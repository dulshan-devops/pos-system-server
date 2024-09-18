using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace pos_system.Migrations
{
    /// <inheritdoc />
    public partial class ChangeDbStructure : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(name: "PurchaseOrder");
            migrationBuilder.DropTable(name: "PurchaseOrderItems");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
            name: "PurchaseOrder",
            columns: table => new
            {
                Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                SupplierId = table.Column<int>(type: "int", nullable: false),
                OrderDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                DeliveryDate = table.Column<DateOnly>(type: "date", nullable: false)
            },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseOrder", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PurchaseOrder_Supplier_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "Supplier",
                        principalColumn: "SupplierId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrder_SupplierId",
                table: "PurchaseOrder",
                column: "SupplierId");

            migrationBuilder.CreateTable(
            name: "PurchaseOrderItems",
            columns: table => new
            {
                Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                PurchaseOrderId = table.Column<int>(type: "int", nullable: false),
                ProductId = table.Column<int>(type: "int", nullable: false),
                CostPrice = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                Quantity = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                ItemTotalAmount = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false)
            },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseOrderItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PurchaseOrderItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrderItems_ProductId",
                table: "PurchaseOrderItems",
                column: "ProductId");
        }
    }
}
