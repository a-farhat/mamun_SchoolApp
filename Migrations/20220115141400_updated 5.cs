using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace mamun_SchoolApp.Migrations
{
    public partial class updated5 : Migration
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
                table: "Classes",
                columns: new[] { "Id", "class_name" },
                values: new object[] { 5, "Grade3" });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "class_name" },
                values: new object[] { 6, "Grade4" });

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
                values: new object[] { 20, 6, 1, new DateTime(2014, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clark Smith16" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "ClassId", "CountryId", "date_of_birth", "name" },
                values: new object[] { 19, 6, 1, new DateTime(2014, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clark Smith15" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "ClassId", "CountryId", "date_of_birth", "name" },
                values: new object[] { 18, 6, 1, new DateTime(2014, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clark Smith14" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "ClassId", "CountryId", "date_of_birth", "name" },
                values: new object[] { 17, 6, 1, new DateTime(2014, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clark Smith13" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "ClassId", "CountryId", "date_of_birth", "name" },
                values: new object[] { 16, 6, 1, new DateTime(2014, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clark Smith12" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "ClassId", "CountryId", "date_of_birth", "name" },
                values: new object[] { 15, 6, 1, new DateTime(2014, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clark Smith11" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "ClassId", "CountryId", "date_of_birth", "name" },
                values: new object[] { 14, 6, 1, new DateTime(2014, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clark Smith10" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "ClassId", "CountryId", "date_of_birth", "name" },
                values: new object[] { 2, 2, 2, new DateTime(2010, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "John Doe" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "ClassId", "CountryId", "date_of_birth", "name" },
                values: new object[] { 12, 6, 1, new DateTime(2014, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clark Smith9" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "ClassId", "CountryId", "date_of_birth", "name" },
                values: new object[] { 10, 4, 1, new DateTime(2012, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clark Smith7" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "ClassId", "CountryId", "date_of_birth", "name" },
                values: new object[] { 9, 4, 1, new DateTime(2012, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clark Smith6" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "ClassId", "CountryId", "date_of_birth", "name" },
                values: new object[] { 8, 4, 1, new DateTime(2012, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clark Smith5" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "ClassId", "CountryId", "date_of_birth", "name" },
                values: new object[] { 7, 4, 1, new DateTime(2012, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clark Smith4" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "ClassId", "CountryId", "date_of_birth", "name" },
                values: new object[] { 6, 4, 1, new DateTime(2012, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clark Smith3" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "ClassId", "CountryId", "date_of_birth", "name" },
                values: new object[] { 5, 4, 1, new DateTime(2012, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clark Smith2" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "ClassId", "CountryId", "date_of_birth", "name" },
                values: new object[] { 4, 4, 1, new DateTime(2008, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clark Boy1" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "ClassId", "CountryId", "date_of_birth", "name" },
                values: new object[] { 11, 6, 1, new DateTime(2014, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clark Smith8" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "ClassId", "CountryId", "date_of_birth", "name" },
                values: new object[] { 3, 3, 3, new DateTime(2009, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Danny Doe" });

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
