using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace M3P_BackEnd_Squad1.Migrations
{
    /// <inheritdoc />
    public partial class inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Collections",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NAME = table.Column<string>(type: "VARCHAR(200)", nullable: false),
                    BRAND = table.Column<string>(type: "VARCHAR(200)", nullable: false),
                    BUDGET = table.Column<decimal>(type: "DECIMAL(18,2)", nullable: false),
                    COLOR = table.Column<string>(type: "VARCHAR(80)", nullable: false),
                    RELEASE_YEAR = table.Column<DateTime>(type: "DATE", nullable: false),
                    SEASONS = table.Column<int>(type: "INT", nullable: false),
                    STATUS = table.Column<int>(type: "INT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Collections", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NAME = table.Column<string>(type: "VARCHAR(200)", nullable: false),
                    CNPJ = table.Column<string>(type: "VARCHAR(14)", nullable: false),
                    MANAGER = table.Column<string>(type: "VARCHAR(200)", nullable: false),
                    EMAIL = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    PASSWORD = table.Column<string>(type: "VARCHAR(200)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NAME = table.Column<string>(type: "VARCHAR(200)", nullable: false),
                    EMAIL = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    ROLE = table.Column<int>(type: "INT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CompaniesSetup",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TEMA = table.Column<int>(type: "INT", nullable: false),
                    LOGO = table.Column<string>(type: "VARCHAR(200)", nullable: false),
                    COMPANY_FK = table.Column<int>(type: "INT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompaniesSetup", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CompaniesSetup_Companies_COMPANY_FK",
                        column: x => x.COMPANY_FK,
                        principalTable: "Companies",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Models",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NAME = table.Column<string>(type: "VARCHAR(200)", nullable: false),
                    Responsible_FK = table.Column<int>(type: "INT", nullable: false),
                    Collection_FK = table.Column<int>(type: "INT", nullable: false),
                    REAL_COST = table.Column<decimal>(type: "DECIMAL(14,2)", nullable: false),
                    TYPE = table.Column<int>(type: "INT", nullable: false),
                    EMBROIDERY = table.Column<bool>(type: "BIT", nullable: false),
                    PRINT = table.Column<bool>(type: "BIT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Models", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Models_Collections_Collection_FK",
                        column: x => x.Collection_FK,
                        principalTable: "Collections",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Models_Users_Responsible_FK",
                        column: x => x.Responsible_FK,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Collections",
                columns: new[] { "ID", "BRAND", "BUDGET", "COLOR", "NAME", "RELEASE_YEAR", "SEASONS", "STATUS" },
                values: new object[,]
                {
                    { 1, "Adidas", 250000m, "Red", "Rising of the Mountains", new DateTime(2004, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0 },
                    { 2, "Outlet", 100000m, "Blue", "Creek of love", new DateTime(2010, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 2 },
                    { 3, "Adidas", 500000m, "White", "Spring Flowers", new DateTime(2014, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1 },
                    { 4, "Jakarta", 50000m, "Black", "Amazon of Brazil", new DateTime(1999, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 3 },
                    { 5, "Umbro", 330700m, "Yellow", "Southern Cold", new DateTime(2023, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "EMAIL", "NAME", "ROLE" },
                values: new object[,]
                {
                    { 1, "Maria@teste.com", "Maria Fernanda", 0 },
                    { 2, "peterson@teste.com", "Peterson Wiggers", 1 },
                    { 3, "marcelo@teste.com", "Marcelo Dias", 2 },
                    { 4, "fabio@teste.com", "Fabio Solva", 1 },
                    { 5, "dejacir@teste.com", "Dejacir Wiggers", 0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Companies_CNPJ",
                table: "Companies",
                column: "CNPJ",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CompaniesSetup_COMPANY_FK",
                table: "CompaniesSetup",
                column: "COMPANY_FK");

            migrationBuilder.CreateIndex(
                name: "IX_Models_Collection_FK",
                table: "Models",
                column: "Collection_FK");

            migrationBuilder.CreateIndex(
                name: "IX_Models_Responsible_FK",
                table: "Models",
                column: "Responsible_FK");

            migrationBuilder.CreateIndex(
                name: "IX_Users_EMAIL",
                table: "Users",
                column: "EMAIL",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CompaniesSetup");

            migrationBuilder.DropTable(
                name: "Models");

            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DropTable(
                name: "Collections");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
