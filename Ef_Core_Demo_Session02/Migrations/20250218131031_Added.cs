using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ef_Core_Demo_Session02.Migrations
{
    /// <inheritdoc />
    public partial class Added : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "WorkForId",
                table: "employees",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EmpId",
                table: "departments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_employees_WorkForId",
                table: "employees",
                column: "WorkForId");

            migrationBuilder.CreateIndex(
                name: "IX_departments_EmpId",
                table: "departments",
                column: "EmpId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_departments_employees_EmpId",
                table: "departments",
                column: "EmpId",
                principalTable: "employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_employees_departments_WorkForId",
                table: "employees",
                column: "WorkForId",
                principalTable: "departments",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_departments_employees_EmpId",
                table: "departments");

            migrationBuilder.DropForeignKey(
                name: "FK_employees_departments_WorkForId",
                table: "employees");

            migrationBuilder.DropIndex(
                name: "IX_employees_WorkForId",
                table: "employees");

            migrationBuilder.DropIndex(
                name: "IX_departments_EmpId",
                table: "departments");

            migrationBuilder.DropColumn(
                name: "WorkForId",
                table: "employees");

            migrationBuilder.DropColumn(
                name: "EmpId",
                table: "departments");
        }
    }
}
