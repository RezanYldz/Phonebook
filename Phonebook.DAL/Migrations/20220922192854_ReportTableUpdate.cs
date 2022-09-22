using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Phonebook.DAL.Migrations
{
    public partial class ReportTableUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PersonId",
                table: "Reports",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Reports_PersonId",
                table: "Reports",
                column: "PersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reports_Persons_PersonId",
                table: "Reports",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reports_Persons_PersonId",
                table: "Reports");

            migrationBuilder.DropIndex(
                name: "IX_Reports_PersonId",
                table: "Reports");

            migrationBuilder.DropColumn(
                name: "PersonId",
                table: "Reports");
        }
    }
}
