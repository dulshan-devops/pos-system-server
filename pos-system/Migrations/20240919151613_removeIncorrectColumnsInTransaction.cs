using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace pos_system.Migrations
{
    /// <inheritdoc />
    public partial class removeIncorrectColumnsInTransaction : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transaction_TransactionType_TransactionTypeId",
                table: "Transaction");

            migrationBuilder.DropColumn(
                name: "TransactiTypeId",
                table: "Transaction");

            migrationBuilder.AlterColumn<int>(
                name: "TransactionTypeId",
                table: "Transaction",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Transaction_TransactionType_TransactionTypeId",
                table: "Transaction",
                column: "TransactionTypeId",
                principalTable: "TransactionType",
                principalColumn: "TransactionTypeId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transaction_TransactionType_TransactionTypeId",
                table: "Transaction");

            migrationBuilder.AlterColumn<int>(
                name: "TransactionTypeId",
                table: "Transaction",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "TransactiTypeId",
                table: "Transaction",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Transaction_TransactionType_TransactionTypeId",
                table: "Transaction",
                column: "TransactionTypeId",
                principalTable: "TransactionType",
                principalColumn: "TransactionTypeId");
        }
    }
}
