using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace rest_tdd.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "books",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_books", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "books",
                columns: new[] { "Id", "Author", "Title" },
                values: new object[,]
                {
                    { new Guid("11111111-1111-1111-1111-111111111111"), "Chinua Achebe", "Things Fall Apart" },
                    { new Guid("22222222-2222-2222-2222-222222222222"), "Ngugi wa Thiong'o", "The River Between" },
                    { new Guid("33333333-3333-3333-3333-333333333333"), "Ngugi wa Thiong'o", "Weep Not, Child" },
                    { new Guid("44444444-4444-4444-4444-444444444444"), "George Orwell", "Animal Farm" },
                    { new Guid("55555555-5555-5555-5555-555555555555"), "George Orwell", "1984" },
                    { new Guid("66666666-6666-6666-6666-666666666666"), "F. Scott Fitzgerald", "The Great Gatsby" },
                    { new Guid("77777777-7777-7777-7777-777777777777"), "Jane Austen", "Pride and Prejudice" },
                    { new Guid("88888888-8888-8888-8888-888888888888"), "Harper Lee", "To Kill a Mockingbird" },
                    { new Guid("99999999-9999-9999-9999-999999999999"), "Paulo Coelho", "The Alchemist" },
                    { new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), "James Clear", "Atomic Habits" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "books");
        }
    }
}
