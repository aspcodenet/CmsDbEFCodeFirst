using Microsoft.EntityFrameworkCore.Migrations;

namespace CmsDbEFCodeFirst.Migrations
{
    public partial class Fixes3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Personer_BankWorker_BankContactId",
                table: "Personer");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BankWorker",
                table: "BankWorker");

            migrationBuilder.RenameTable(
                name: "BankWorker",
                newName: "BankWorkers");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BankWorkers",
                table: "BankWorkers",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Personer_BankWorkers_BankContactId",
                table: "Personer",
                column: "BankContactId",
                principalTable: "BankWorkers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Personer_BankWorkers_BankContactId",
                table: "Personer");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BankWorkers",
                table: "BankWorkers");

            migrationBuilder.RenameTable(
                name: "BankWorkers",
                newName: "BankWorker");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BankWorker",
                table: "BankWorker",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Personer_BankWorker_BankContactId",
                table: "Personer",
                column: "BankContactId",
                principalTable: "BankWorker",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
