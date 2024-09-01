﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeManagement.Migrations
{
    /// <inheritdoc />
    public partial class company3migration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_EmployeeMaster_DPTId",
                table: "EmployeeMaster",
                column: "DPTId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeMaster_DepartmentMaster_DPTId",
                table: "EmployeeMaster",
                column: "DPTId",
                principalTable: "DepartmentMaster",
                principalColumn: "DPTId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeMaster_DepartmentMaster_DPTId",
                table: "EmployeeMaster");

            migrationBuilder.DropIndex(
                name: "IX_EmployeeMaster_DPTId",
                table: "EmployeeMaster");
        }
    }
}
