using Microsoft.EntityFrameworkCore.Migrations;

namespace MicroRabbitMQ.Transfer.Data.Migrations
{
    public partial class MudandoNomeColuna : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AccountBalance",
                table: "TransferLogs",
                newName: "TransferAmount");

            migrationBuilder.AlterColumn<int>(
                name: "ToAccount",
                table: "TransferLogs",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "FromAccount",
                table: "TransferLogs",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TransferAmount",
                table: "TransferLogs",
                newName: "AccountBalance");

            migrationBuilder.AlterColumn<string>(
                name: "ToAccount",
                table: "TransferLogs",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "FromAccount",
                table: "TransferLogs",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
