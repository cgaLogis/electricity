using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Electricity.DAL.Migrations
{
    public partial class ElectricityPointIds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ElectricityMeters_ElectricityPoints_ElectricityPointId",
                table: "ElectricityMeters");

            migrationBuilder.DropForeignKey(
                name: "FK_ElectricityPoints_ConsumptionObjects_ObjectId",
                table: "ElectricityPoints");

            migrationBuilder.DropForeignKey(
                name: "FK_ElectricityTransformators_ElectricityPoints_ElectricityPointId",
                table: "ElectricityTransformators");

            migrationBuilder.DropForeignKey(
                name: "FK_VoltageTransformators_ElectricityPoints_ElectricityPointId",
                table: "VoltageTransformators");

            migrationBuilder.DropIndex(
                name: "IX_VoltageTransformators_ElectricityPointId",
                table: "VoltageTransformators");

            migrationBuilder.DropIndex(
                name: "IX_ElectricityTransformators_ElectricityPointId",
                table: "ElectricityTransformators");

            migrationBuilder.DropIndex(
                name: "IX_ElectricityMeters_ElectricityPointId",
                table: "ElectricityMeters");

            migrationBuilder.AlterColumn<int>(
                name: "ElectricityPointId",
                table: "VoltageTransformators",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "ElectricityPointId",
                table: "ElectricityTransformators",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "ObjectId",
                table: "ElectricityPoints",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "ElectricityMeterId",
                table: "ElectricityPoints",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ElectricityTransformatorId",
                table: "ElectricityPoints",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VoltageTransformatorId",
                table: "ElectricityPoints",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ElectricityPointId",
                table: "ElectricityMeters",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.InsertData(
                table: "ElectricityPoints",
                columns: new[] { "Id", "ElectricityMeterId", "ElectricityTransformatorId", "Name", "ObjectId", "VoltageTransformatorId" },
                values: new object[] { 1, 1, 1, "Hello I'm point", null, 1 });

            migrationBuilder.InsertData(
                table: "ElectricityPoints",
                columns: new[] { "Id", "ElectricityMeterId", "ElectricityTransformatorId", "Name", "ObjectId", "VoltageTransformatorId" },
                values: new object[] { 2, 2, 2, "Hello I'm point", null, 2 });

            migrationBuilder.InsertData(
                table: "ElectricityMeters",
                columns: new[] { "Id", "ElectricityPointId", "Number", "Type", "ValidationDate" },
                values: new object[,]
                {
                    { 1, 1, "KakoitoNomer", 1, new DateTime(2012, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 2, "KakoitoNomer", 1, new DateTime(2017, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "ElectricityTransformators",
                columns: new[] { "Id", "ElectricityPointId", "KTT", "Number", "Type", "ValidationDate" },
                values: new object[,]
                {
                    { 1, 1, 12312, "123123123", 1, new DateTime(2012, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 2, 12312, "123123123", 1, new DateTime(2017, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "VoltageTransformators",
                columns: new[] { "Id", "ElectricityPointId", "KTN", "Number", "Type", "ValidationDate" },
                values: new object[,]
                {
                    { 1, 1, 123123, "123123", 1, new DateTime(2012, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 2, 123123, "123123", 1, new DateTime(2017, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_VoltageTransformators_ElectricityPointId",
                table: "VoltageTransformators",
                column: "ElectricityPointId",
                unique: true,
                filter: "[ElectricityPointId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ElectricityTransformators_ElectricityPointId",
                table: "ElectricityTransformators",
                column: "ElectricityPointId",
                unique: true,
                filter: "[ElectricityPointId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ElectricityMeters_ElectricityPointId",
                table: "ElectricityMeters",
                column: "ElectricityPointId",
                unique: true,
                filter: "[ElectricityPointId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_ElectricityMeters_ElectricityPoints_ElectricityPointId",
                table: "ElectricityMeters",
                column: "ElectricityPointId",
                principalTable: "ElectricityPoints",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ElectricityPoints_ConsumptionObjects_ObjectId",
                table: "ElectricityPoints",
                column: "ObjectId",
                principalTable: "ConsumptionObjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ElectricityTransformators_ElectricityPoints_ElectricityPointId",
                table: "ElectricityTransformators",
                column: "ElectricityPointId",
                principalTable: "ElectricityPoints",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_VoltageTransformators_ElectricityPoints_ElectricityPointId",
                table: "VoltageTransformators",
                column: "ElectricityPointId",
                principalTable: "ElectricityPoints",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ElectricityMeters_ElectricityPoints_ElectricityPointId",
                table: "ElectricityMeters");

            migrationBuilder.DropForeignKey(
                name: "FK_ElectricityPoints_ConsumptionObjects_ObjectId",
                table: "ElectricityPoints");

            migrationBuilder.DropForeignKey(
                name: "FK_ElectricityTransformators_ElectricityPoints_ElectricityPointId",
                table: "ElectricityTransformators");

            migrationBuilder.DropForeignKey(
                name: "FK_VoltageTransformators_ElectricityPoints_ElectricityPointId",
                table: "VoltageTransformators");

            migrationBuilder.DropIndex(
                name: "IX_VoltageTransformators_ElectricityPointId",
                table: "VoltageTransformators");

            migrationBuilder.DropIndex(
                name: "IX_ElectricityTransformators_ElectricityPointId",
                table: "ElectricityTransformators");

            migrationBuilder.DropIndex(
                name: "IX_ElectricityMeters_ElectricityPointId",
                table: "ElectricityMeters");

            migrationBuilder.DeleteData(
                table: "ElectricityMeters",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ElectricityMeters",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ElectricityTransformators",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ElectricityTransformators",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "VoltageTransformators",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "VoltageTransformators",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ElectricityPoints",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ElectricityPoints",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "ElectricityMeterId",
                table: "ElectricityPoints");

            migrationBuilder.DropColumn(
                name: "ElectricityTransformatorId",
                table: "ElectricityPoints");

            migrationBuilder.DropColumn(
                name: "VoltageTransformatorId",
                table: "ElectricityPoints");

            migrationBuilder.AlterColumn<int>(
                name: "ElectricityPointId",
                table: "VoltageTransformators",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ElectricityPointId",
                table: "ElectricityTransformators",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ObjectId",
                table: "ElectricityPoints",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ElectricityPointId",
                table: "ElectricityMeters",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_VoltageTransformators_ElectricityPointId",
                table: "VoltageTransformators",
                column: "ElectricityPointId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ElectricityTransformators_ElectricityPointId",
                table: "ElectricityTransformators",
                column: "ElectricityPointId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ElectricityMeters_ElectricityPointId",
                table: "ElectricityMeters",
                column: "ElectricityPointId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ElectricityMeters_ElectricityPoints_ElectricityPointId",
                table: "ElectricityMeters",
                column: "ElectricityPointId",
                principalTable: "ElectricityPoints",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ElectricityPoints_ConsumptionObjects_ObjectId",
                table: "ElectricityPoints",
                column: "ObjectId",
                principalTable: "ConsumptionObjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ElectricityTransformators_ElectricityPoints_ElectricityPointId",
                table: "ElectricityTransformators",
                column: "ElectricityPointId",
                principalTable: "ElectricityPoints",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VoltageTransformators_ElectricityPoints_ElectricityPointId",
                table: "VoltageTransformators",
                column: "ElectricityPointId",
                principalTable: "ElectricityPoints",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
