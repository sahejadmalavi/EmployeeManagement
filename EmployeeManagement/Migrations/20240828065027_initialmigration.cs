using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeManagement.Migrations
{
    /// <inheritdoc />
    public partial class initialmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DepartmentMaster",
                columns: table => new
                {
                    DPTId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DPTName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DPTIsActive = table.Column<bool>(type: "bit", nullable: false),
                    DPTCreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DPTUpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepartmentMaster", x => x.DPTId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DepartmentMaster");
        }
    }
}
