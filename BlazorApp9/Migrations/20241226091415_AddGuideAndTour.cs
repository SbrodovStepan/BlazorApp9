using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorApp9.Migrations
{
    /// <inheritdoc />
    public partial class AddGuideAndTour : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Places",
                table: "Tours");

            migrationBuilder.RenameColumn(
                name: "ContactInfo",
                table: "Guides",
                newName: "Phone");

            migrationBuilder.RenameColumn(
                name: "AssignedTours",
                table: "Guides",
                newName: "Email");

            migrationBuilder.CreateIndex(
                name: "IX_Tours_GuideId",
                table: "Tours",
                column: "GuideId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tours_Guides_GuideId",
                table: "Tours",
                column: "GuideId",
                principalTable: "Guides",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tours_Guides_GuideId",
                table: "Tours");

            migrationBuilder.DropIndex(
                name: "IX_Tours_GuideId",
                table: "Tours");

            migrationBuilder.RenameColumn(
                name: "Phone",
                table: "Guides",
                newName: "ContactInfo");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Guides",
                newName: "AssignedTours");

            migrationBuilder.AddColumn<string>(
                name: "Places",
                table: "Tours",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }
    }
}
