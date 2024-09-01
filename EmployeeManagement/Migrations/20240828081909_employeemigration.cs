using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeManagement.Migrations
{
    /// <inheritdoc />
    public partial class employeemigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EmployeeMaster",
                columns: table => new
                {
                    EMPId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EMPFirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EMPLastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EMPImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EMPDob = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EMPPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EMPGender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EMPQualification = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EMPCity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EMPState = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EMPPincode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EMPAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EMPEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EMPUserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EMPPassword = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DPTId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ADMId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EMPSchedule = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EMPJoiningDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EMPIsActive = table.Column<bool>(type: "bit", nullable: false),
                    EMPCreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EMPUpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeMaster", x => x.EMPId);
                    table.ForeignKey(
                        name: "FK_EmployeeMaster_DepartmentMaster_DPTId",
                        column: x => x.DPTId,
                        principalTable: "DepartmentMaster",
                        principalColumn: "DPTId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeMaster_DPTId",
                table: "EmployeeMaster",
                column: "DPTId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeMaster");
        }
    }
}
