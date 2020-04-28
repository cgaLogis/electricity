using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Electricity.DAL.Migrations
{
    public partial class INit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Organizations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organizations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ChildOrganizations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    ParentId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChildOrganizations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChildOrganizations_Organizations_ParentId",
                        column: x => x.ParentId,
                        principalTable: "Organizations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ConsumptionObjects",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    OrganizationId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConsumptionObjects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ConsumptionObjects_ChildOrganizations_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "ChildOrganizations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DeliveryPoints",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    MaxPower = table.Column<int>(nullable: false),
                    ConsumptionObjectId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeliveryPoints", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DeliveryPoints_ConsumptionObjects_ConsumptionObjectId",
                        column: x => x.ConsumptionObjectId,
                        principalTable: "ConsumptionObjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ElectricityPoints",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    ObjectId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ElectricityPoints", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ElectricityPoints_ConsumptionObjects_ObjectId",
                        column: x => x.ObjectId,
                        principalTable: "ConsumptionObjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DeliveryPointMeters",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DeliveryPointId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeliveryPointMeters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DeliveryPointMeters_DeliveryPoints_DeliveryPointId",
                        column: x => x.DeliveryPointId,
                        principalTable: "DeliveryPoints",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ElectricityMeters",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Number = table.Column<string>(nullable: true),
                    Type = table.Column<int>(nullable: true),
                    ValidationDate = table.Column<DateTime>(nullable: true),
                    ElectricityPointId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ElectricityMeters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ElectricityMeters_ElectricityPoints_ElectricityPointId",
                        column: x => x.ElectricityPointId,
                        principalTable: "ElectricityPoints",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ElectricityTransformators",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Number = table.Column<string>(nullable: true),
                    Type = table.Column<int>(nullable: true),
                    KTT = table.Column<int>(nullable: true),
                    ValidationDate = table.Column<DateTime>(nullable: true),
                    ElectricityPointId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ElectricityTransformators", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ElectricityTransformators_ElectricityPoints_ElectricityPointId",
                        column: x => x.ElectricityPointId,
                        principalTable: "ElectricityPoints",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VoltageTransformators",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Number = table.Column<string>(nullable: true),
                    KTN = table.Column<int>(nullable: true),
                    ValidationDate = table.Column<DateTime>(nullable: true),
                    Type = table.Column<int>(nullable: true),
                    ElectricityPointId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VoltageTransformators", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VoltageTransformators_ElectricityPoints_ElectricityPointId",
                        column: x => x.ElectricityPointId,
                        principalTable: "ElectricityPoints",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Address", "Name" },
                values: new object[] { 1, "Moscow", "Test" });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Address", "Name" },
                values: new object[] { 2, "Moscow", "Test" });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Address", "Name" },
                values: new object[] { 3, "Moscow", "Test" });

            migrationBuilder.InsertData(
                table: "ChildOrganizations",
                columns: new[] { "Id", "Address", "Name", "ParentId" },
                values: new object[,]
                {
                    { 1, "Moscow", "Child1", 1 },
                    { 2, "Moscow", "Child1", 1 },
                    { 3, "Moscow", "Child1", 2 },
                    { 4, "Moscow", "Child1", 3 }
                });

            migrationBuilder.InsertData(
                table: "ConsumptionObjects",
                columns: new[] { "Id", "Address", "Name", "OrganizationId" },
                values: new object[,]
                {
                    { 1, "Empty address", "Объект потребления 1", 1 },
                    { 2, "Empty address", "Объект потребления 1", 1 },
                    { 3, "Empty address", "Объект потребления 1", 1 },
                    { 4, "Empty address", "Объект потребления 1", 1 },
                    { 5, "Empty address", "Объект потребления 1", 1 }
                });

            migrationBuilder.InsertData(
                table: "DeliveryPoints",
                columns: new[] { "Id", "ConsumptionObjectId", "MaxPower", "Name" },
                values: new object[,]
                {
                    { 1, 1, 100, "Точка поставки электроэнергии 1 " },
                    { 2, 2, 100, "Точка поставки электроэнергии 1 " },
                    { 3, 3, 100, "Точка поставки электроэнергии 1 " },
                    { 4, 4, 100, "Точка поставки электроэнергии 1 " },
                    { 5, 4, 100, "Точка поставки электроэнергии 1 " }
                });

            migrationBuilder.InsertData(
                table: "DeliveryPointMeters",
                columns: new[] { "Id", "DeliveryPointId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 },
                    { 3, 3 },
                    { 4, 4 },
                    { 5, 5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChildOrganizations_ParentId",
                table: "ChildOrganizations",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_ConsumptionObjects_OrganizationId",
                table: "ConsumptionObjects",
                column: "OrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_DeliveryPointMeters_DeliveryPointId",
                table: "DeliveryPointMeters",
                column: "DeliveryPointId");

            migrationBuilder.CreateIndex(
                name: "IX_DeliveryPoints_ConsumptionObjectId",
                table: "DeliveryPoints",
                column: "ConsumptionObjectId");

            migrationBuilder.CreateIndex(
                name: "IX_ElectricityMeters_ElectricityPointId",
                table: "ElectricityMeters",
                column: "ElectricityPointId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ElectricityPoints_ObjectId",
                table: "ElectricityPoints",
                column: "ObjectId");

            migrationBuilder.CreateIndex(
                name: "IX_ElectricityTransformators_ElectricityPointId",
                table: "ElectricityTransformators",
                column: "ElectricityPointId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_VoltageTransformators_ElectricityPointId",
                table: "VoltageTransformators",
                column: "ElectricityPointId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DeliveryPointMeters");

            migrationBuilder.DropTable(
                name: "ElectricityMeters");

            migrationBuilder.DropTable(
                name: "ElectricityTransformators");

            migrationBuilder.DropTable(
                name: "VoltageTransformators");

            migrationBuilder.DropTable(
                name: "DeliveryPoints");

            migrationBuilder.DropTable(
                name: "ElectricityPoints");

            migrationBuilder.DropTable(
                name: "ConsumptionObjects");

            migrationBuilder.DropTable(
                name: "ChildOrganizations");

            migrationBuilder.DropTable(
                name: "Organizations");
        }
    }
}
