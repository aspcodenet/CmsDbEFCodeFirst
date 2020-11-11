using Microsoft.EntityFrameworkCore.Migrations;

namespace CmsDbEFCodeFirst.Migrations
{
    public partial class Fixes2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BankContactId",
                table: "Personer",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "BankWorker",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BankWorker", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Personer_BankContactId",
                table: "Personer",
                column: "BankContactId");

            migrationBuilder.AddForeignKey(
                name: "FK_Personer_BankWorker_BankContactId",
                table: "Personer",
                column: "BankContactId",
                principalTable: "BankWorker",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Personer_BankWorker_BankContactId",
                table: "Personer");

            migrationBuilder.DropTable(
                name: "BankWorker");

            migrationBuilder.DropIndex(
                name: "IX_Personer_BankContactId",
                table: "Personer");

            migrationBuilder.DropColumn(
                name: "BankContactId",
                table: "Personer");
        }
    }
}
