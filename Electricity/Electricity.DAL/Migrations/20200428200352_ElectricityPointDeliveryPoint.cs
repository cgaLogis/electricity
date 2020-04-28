using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Electricity.DAL.Migrations
{
    public partial class ElectricityPointDeliveryPoint : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ElectricityPointDeliveryPointMeters",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ElectricityPointId = table.Column<int>(nullable: false),
                    DeliveryPointMeterId = table.Column<int>(nullable: false),
                    Created = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ElectricityPointDeliveryPointMeters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ElectricityPointDeliveryPointMeters_DeliveryPointMeters_DeliveryPointMeterId",
                        column: x => x.DeliveryPointMeterId,
                        principalTable: "DeliveryPointMeters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ElectricityPointDeliveryPointMeters_ElectricityPoints_ElectricityPointId",
                        column: x => x.ElectricityPointId,
                        principalTable: "ElectricityPoints",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "ElectricityPoints",
                keyColumn: "Id",
                keyValue: 1,
                column: "ObjectId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ElectricityPoints",
                keyColumn: "Id",
                keyValue: 2,
                column: "ObjectId",
                value: 1);

            migrationBuilder.CreateIndex(
                name: "IX_ElectricityPointDeliveryPointMeters_DeliveryPointMeterId",
                table: "ElectricityPointDeliveryPointMeters",
                column: "DeliveryPointMeterId");

            migrationBuilder.CreateIndex(
                name: "IX_ElectricityPointDeliveryPointMeters_ElectricityPointId",
                table: "ElectricityPointDeliveryPointMeters",
                column: "ElectricityPointId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ElectricityPointDeliveryPointMeters");

            migrationBuilder.UpdateData(
                table: "ElectricityPoints",
                keyColumn: "Id",
                keyValue: 1,
                column: "ObjectId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ElectricityPoints",
                keyColumn: "Id",
                keyValue: 2,
                column: "ObjectId",
                value: null);
        }
    }
}
