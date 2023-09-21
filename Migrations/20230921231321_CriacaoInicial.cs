using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace M3P_BackEnd_Squad1.Migrations
{
    /// <inheritdoc />
    public partial class CriacaoInicial : Migration
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
