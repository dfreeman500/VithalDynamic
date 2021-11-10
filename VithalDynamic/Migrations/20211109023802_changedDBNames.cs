using Microsoft.EntityFrameworkCore.Migrations;

namespace VithalDynamic.Migrations
{
    public partial class changedDBNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Event_Person_OrderDetailId",
                table: "Event");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Person",
                table: "Person");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Event",
                table: "Event");

            migrationBuilder.RenameTable(
                name: "Person",
                newName: "OrderDetails");

            migrationBuilder.RenameTable(
                name: "Event",
                newName: "OrderModels");

            migrationBuilder.RenameIndex(
                name: "IX_Event_OrderDetailId",
                table: "OrderModels",
                newName: "IX_OrderModels_OrderDetailId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderDetails",
                table: "OrderDetails",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderModels",
                table: "OrderModels",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderModels_OrderDetails_OrderDetailId",
                table: "OrderModels",
                column: "OrderDetailId",
                principalTable: "OrderDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderModels_OrderDetails_OrderDetailId",
                table: "OrderModels");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderModels",
                table: "OrderModels");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderDetails",
                table: "OrderDetails");

            migrationBuilder.RenameTable(
                name: "OrderModels",
                newName: "Event");

            migrationBuilder.RenameTable(
                name: "OrderDetails",
                newName: "Person");

            migrationBuilder.RenameIndex(
                name: "IX_OrderModels_OrderDetailId",
                table: "Event",
                newName: "IX_Event_OrderDetailId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Event",
                table: "Event",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Person",
                table: "Person",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Event_Person_OrderDetailId",
                table: "Event",
                column: "OrderDetailId",
                principalTable: "Person",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
