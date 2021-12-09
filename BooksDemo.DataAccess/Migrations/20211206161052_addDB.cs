using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BooksDemo.DataAccess.Migrations
{
    public partial class addDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTimeOffset>(nullable: false),
                    ModifiedDate = table.Column<DateTimeOffset>(nullable: true),
                    Timestamp = table.Column<byte[]>(rowVersion: true, nullable: true),
                    Creator = table.Column<int>(nullable: false),
                    Modifier = table.Column<int>(nullable: true),
                    BookTitle = table.Column<string>(nullable: true),
                    ISBN = table.Column<long>(nullable: false),
                    PublishYear = table.Column<int>(nullable: false),
                    CoverPrice = table.Column<decimal>(nullable: false),
                    CheckStatus = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");
        }
    }
}
