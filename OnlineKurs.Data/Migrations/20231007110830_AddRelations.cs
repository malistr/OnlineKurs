using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineKurs.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddRelations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Videos_Courses_CourseId",
                table: "Videos");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Categories");

            migrationBuilder.AlterColumn<int>(
                name: "CourseId",
                table: "Videos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SubCategoryId",
                table: "Videos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StudentId",
                table: "Comments",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "SubCategory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateDeleted = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCategory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubCategory_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Videos_SubCategoryId",
                table: "Videos",
                column: "SubCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_StudentId",
                table: "Comments",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_SubCategory_CategoryId",
                table: "SubCategory",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Students_StudentId",
                table: "Comments",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Videos_Courses_CourseId",
                table: "Videos",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Videos_SubCategory_SubCategoryId",
                table: "Videos",
                column: "SubCategoryId",
                principalTable: "SubCategory",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Students_StudentId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Videos_Courses_CourseId",
                table: "Videos");

            migrationBuilder.DropForeignKey(
                name: "FK_Videos_SubCategory_SubCategoryId",
                table: "Videos");

            migrationBuilder.DropTable(
                name: "SubCategory");

            migrationBuilder.DropIndex(
                name: "IX_Videos_SubCategoryId",
                table: "Videos");

            migrationBuilder.DropIndex(
                name: "IX_Comments_StudentId",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "SubCategoryId",
                table: "Videos");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "Comments");

            migrationBuilder.AlterColumn<int>(
                name: "CourseId",
                table: "Videos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_Videos_Courses_CourseId",
                table: "Videos",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id");
        }
    }
}
