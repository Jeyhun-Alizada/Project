using Microsoft.EntityFrameworkCore.Migrations;

namespace FrontToASP.Migrations
{
    public partial class CustomerCommenstUpdateed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "CustomerComments",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 150,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Comment",
                table: "CustomerComments",
                maxLength: 150,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Comment",
                table: "CustomerComments");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "CustomerComments",
                maxLength: 150,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldNullable: true);
        }
    }
}
