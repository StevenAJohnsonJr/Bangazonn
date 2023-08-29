using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bangazonn.Migrations
{
    public partial class UidToUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Uid",
                table: "Users",
                type: "text",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Uid",
                value: "ZjnYscBnyAOQCwSCi1NWLYjo6bs1");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "Uid",
                value: "ZjnYscBnyAOQCwSCi1NWLYjo6bs1");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "Uid",
                value: "ZjnYscBnyAOQCwSCi1NWLYjo6bs1");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "Uid",
                value: "ZjnYscBnyAOQCwSCi1NWLYjo6bs1");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "Uid",
                value: "ZjnYscBnyAOQCwSCi1NWLYjo6bs1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Uid",
                table: "Users");
        }
    }
}
