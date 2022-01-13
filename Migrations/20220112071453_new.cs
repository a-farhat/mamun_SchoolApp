using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace mamun_SchoolApp.Migrations
{
    public partial class @new : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    class_id = table.Column<int>(type: "INTEGER", nullable: true),
                    country_id = table.Column<int>(type: "INTEGER", nullable: true),
                    name = table.Column<string>(type: "TEXT", nullable: true),
                    date_of_birth = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ClassId = table.Column<int>(type: "INTEGER", nullable: true),
                    CountryId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "_Classes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    class_name = table.Column<string>(type: "TEXT", nullable: true),
                    StudentsId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Classes", x => x.Id);
                    table.ForeignKey(
                        name: "FK__Classes_Students_StudentsId",
                        column: x => x.StudentsId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "_Countries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(type: "TEXT", nullable: true),
                    StudentsId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Countries", x => x.Id);
                    table.ForeignKey(
                        name: "FK__Countries_Students_StudentsId",
                        column: x => x.StudentsId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "ClassId", "CountryId", "class_id", "country_id", "date_of_birth", "name" },
                values: new object[] { 1, null, null, 1, 1, new DateTime(2012, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Peter Smith" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "ClassId", "CountryId", "class_id", "country_id", "date_of_birth", "name" },
                values: new object[] { 2, null, null, 2, 2, new DateTime(2010, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "John Doe" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "ClassId", "CountryId", "class_id", "country_id", "date_of_birth", "name" },
                values: new object[] { 3, null, null, 3, 3, new DateTime(2009, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Danny Doe" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "ClassId", "CountryId", "class_id", "country_id", "date_of_birth", "name" },
                values: new object[] { 4, null, null, 4, 4, new DateTime(2008, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clark Smith" });

            migrationBuilder.InsertData(
                table: "_Classes",
                columns: new[] { "Id", "StudentsId", "class_name" },
                values: new object[] { 1, null, "KGI" });

            migrationBuilder.InsertData(
                table: "_Classes",
                columns: new[] { "Id", "StudentsId", "class_name" },
                values: new object[] { 2, null, "KGII" });

            migrationBuilder.InsertData(
                table: "_Classes",
                columns: new[] { "Id", "StudentsId", "class_name" },
                values: new object[] { 3, null, "Grade1" });

            migrationBuilder.InsertData(
                table: "_Classes",
                columns: new[] { "Id", "StudentsId", "class_name" },
                values: new object[] { 4, null, "Grade2" });

            migrationBuilder.InsertData(
                table: "_Countries",
                columns: new[] { "Id", "StudentsId", "name" },
                values: new object[] { 1, null, "United States" });

            migrationBuilder.InsertData(
                table: "_Countries",
                columns: new[] { "Id", "StudentsId", "name" },
                values: new object[] { 2, null, "Oman" });

            migrationBuilder.InsertData(
                table: "_Countries",
                columns: new[] { "Id", "StudentsId", "name" },
                values: new object[] { 3, null, "Canada" });

            migrationBuilder.InsertData(
                table: "_Countries",
                columns: new[] { "Id", "StudentsId", "name" },
                values: new object[] { 4, null, "United Kindgom" });

            migrationBuilder.CreateIndex(
                name: "IX__Classes_StudentsId",
                table: "_Classes",
                column: "StudentsId");

            migrationBuilder.CreateIndex(
                name: "IX__Countries_StudentsId",
                table: "_Countries",
                column: "StudentsId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_ClassId",
                table: "Students",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_CountryId",
                table: "Students",
                column: "CountryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Students__Classes_ClassId",
                table: "Students",
                column: "ClassId",
                principalTable: "_Classes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Students__Countries_CountryId",
                table: "Students",
                column: "CountryId",
                principalTable: "_Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK__Classes_Students_StudentsId",
                table: "_Classes");

            migrationBuilder.DropForeignKey(
                name: "FK__Countries_Students_StudentsId",
                table: "_Countries");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "_Classes");

            migrationBuilder.DropTable(
                name: "_Countries");
        }
    }
}
