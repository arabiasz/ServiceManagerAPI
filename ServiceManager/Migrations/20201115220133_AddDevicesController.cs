using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ServiceManager.Migrations
{
    public partial class AddDevicesController : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Devices",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    DevicesFolderId = table.Column<Guid>(nullable: false),
                    SerialNumber = table.Column<string>(maxLength: 50, nullable: false),
                    RegistrationNumber = table.Column<string>(maxLength: 50, nullable: true),
                    ReviewInterval = table.Column<int>(nullable: false),
                    WarrantyInterval = table.Column<int>(nullable: false),
                    InterimReviewDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Devices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Devices_DevicesFolder_DevicesFolderId",
                        column: x => x.DevicesFolderId,
                        principalTable: "DevicesFolder",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Module",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    DeviceId = table.Column<Guid>(nullable: false),
                    UniqueNumber = table.Column<string>(maxLength: 50, nullable: false),
                    Active = table.Column<bool>(nullable: false),
                    Status = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Module", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Module_Devices_DeviceId",
                        column: x => x.DeviceId,
                        principalTable: "Devices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Devices_DevicesFolderId",
                table: "Devices",
                column: "DevicesFolderId");

            migrationBuilder.CreateIndex(
                name: "IX_Module_DeviceId",
                table: "Module",
                column: "DeviceId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Module");

            migrationBuilder.DropTable(
                name: "Devices");
        }
    }
}
