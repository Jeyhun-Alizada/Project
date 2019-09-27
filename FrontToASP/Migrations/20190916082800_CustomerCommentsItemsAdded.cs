using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FrontToASP.Migrations
{
    public partial class CustomerCommentsItemsAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Comment",
                table: "CustomerComments");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "CustomerComments");

            migrationBuilder.DropColumn(
                name: "ImageAlt",
                table: "CustomerComments");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "CustomerComments");

            migrationBuilder.DropColumn(
                name: "Speciality",
                table: "CustomerComments");

            migrationBuilder.CreateTable(
                name: "CustomerCommentsItems",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Image = table.Column<string>(maxLength: 255, nullable: true),
                    ImageAlt = table.Column<string>(maxLength: 150, nullable: true),
                    Comment = table.Column<string>(maxLength: 150, nullable: true),
                    Name = table.Column<string>(maxLength: 255, nullable: true),
                    Speciality = table.Column<string>(maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerCommentsItems", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomerCommentsItems");

            migrationBuilder.AddColumn<string>(
                name: "Comment",
                table: "CustomerComments",
                maxLength: 150,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "CustomerComments",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageAlt",
                table: "CustomerComments",
                maxLength: 150,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "CustomerComments",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Speciality",
                table: "CustomerComments",
                maxLength: 150,
                nullable: true);
        }
    }
}
