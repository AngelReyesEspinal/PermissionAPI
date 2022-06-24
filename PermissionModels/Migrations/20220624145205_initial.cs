using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PermissionModels.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PermissionTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    UpdatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PermissionTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Permissions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeFirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeLastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PermissionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PermissionTypeId = table.Column<int>(type: "int", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    UpdatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permissions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Permissions_PermissionTypes_PermissionTypeId",
                        column: x => x.PermissionTypeId,
                        principalTable: "PermissionTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "PermissionTypes",
                columns: new[] { "Id", "CreatedDate", "Deleted", "Description", "UpdatedDate" },
                values: new object[] { 1, new DateTimeOffset(new DateTime(2022, 6, 24, 10, 52, 5, 621, DateTimeKind.Unspecified).AddTicks(4910), new TimeSpan(0, -4, 0, 0, 0)), false, "Enfermedad", null });

            migrationBuilder.InsertData(
                table: "PermissionTypes",
                columns: new[] { "Id", "CreatedDate", "Deleted", "Description", "UpdatedDate" },
                values: new object[] { 2, new DateTimeOffset(new DateTime(2022, 6, 24, 10, 52, 5, 621, DateTimeKind.Unspecified).AddTicks(4950), new TimeSpan(0, -4, 0, 0, 0)), false, "Diligencias", null });

            migrationBuilder.InsertData(
                table: "PermissionTypes",
                columns: new[] { "Id", "CreatedDate", "Deleted", "Description", "UpdatedDate" },
                values: new object[] { 3, new DateTimeOffset(new DateTime(2022, 6, 24, 10, 52, 5, 621, DateTimeKind.Unspecified).AddTicks(4950), new TimeSpan(0, -4, 0, 0, 0)), false, "Otros", null });

            migrationBuilder.CreateIndex(
                name: "IX_Permissions_PermissionTypeId",
                table: "Permissions",
                column: "PermissionTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Permissions");

            migrationBuilder.DropTable(
                name: "PermissionTypes");
        }
    }
}
