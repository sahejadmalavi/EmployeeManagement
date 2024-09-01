using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeManagement.Migrations
{
    /// <inheritdoc />
    public partial class companymigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CompanyMaster",
                columns: table => new
                {
                    CMPId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CMPName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CMPIsActive = table.Column<bool>(type: "bit", nullable: false),
                    CMPCreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CMPUpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyMaster", x => x.CMPId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CompanyMaster");
        }
    }
}
