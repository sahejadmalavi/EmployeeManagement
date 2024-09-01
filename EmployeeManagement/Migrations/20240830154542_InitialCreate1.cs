using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeManagement.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeMaster_DepartmentMaster_DPTId",
                table: "EmployeeMaster");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeMaster_DepartmentMaster_DPTId",
                table: "EmployeeMaster",
                column: "DPTId",
                principalTable: "DepartmentMaster",
                principalColumn: "DPTId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeMaster_DepartmentMaster_DPTId",
                table: "EmployeeMaster");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeMaster_DepartmentMaster_DPTId",
                table: "EmployeeMaster",
                column: "DPTId",
                principalTable: "DepartmentMaster",
                principalColumn: "DPTId");
        }
    }
}
