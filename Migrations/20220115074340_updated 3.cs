using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace mamun_SchoolApp.Migrations
{
    public partial class updated3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Classes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    class_name = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(type: "TEXT", nullable: true),
                    date_of_birth = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ClassId = table.Column<int>(type: "INTEGER", nullable: true),
                    CountryId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Students_Classes_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Classes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Students_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "class_name" },
                values: new object[] { 1, "KGI" });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "class_name" },
                values: new object[] { 2, "KGII" });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "class_name" },
                values: new object[] { 3, "Grade1" });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "class_name" },
                values: new object[] { 4, "Grade2" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "name" },
                values: new object[] { 1, "United States" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "name" },
                values: new object[] { 2, "Oman" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "name" },
                values: new object[] { 3, "Canada" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "name" },
                values: new object[] { 4, "United Kindgom" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "ClassId", "CountryId", "date_of_birth", "name" },
                values: new object[] { 1, 1, 1, new DateTime(2012, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Peter Smith" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "ClassId", "CountryId", "date_of_birth", "name" },
                values: new object[] { 2, 2, 2, new DateTime(2010, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "John Doe" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "ClassId", "CountryId", "date_of_birth", "name" },
                values: new object[] { 3, 3, 3, new DateTime(2009, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Danny Doe" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "ClassId", "CountryId", "date_of_birth", "name" },
                values: new object[] { 4, 4, 4, new DateTime(2008, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clark Smith" });

            migrationBuilder.CreateIndex(
                name: "IX_Students_ClassId",
                table: "Students",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_CountryId",
                table: "Students",
                column: "CountryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Classes");

            migrationBuilder.DropTable(
                name: "Countries");
        }
    }
}
