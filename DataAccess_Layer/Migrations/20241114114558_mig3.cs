using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess_Layer.Migrations
{
    /// <inheritdoc />
    public partial class mig3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "JoobId",
                table: "customers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "joopJoobId",
                table: "customers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "joops",
                columns: table => new
                {
                    JoobId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JoobName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_joops", x => x.JoobId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_customers_joopJoobId",
                table: "customers",
                column: "joopJoobId");

            migrationBuilder.AddForeignKey(
                name: "FK_customers_joops_joopJoobId",
                table: "customers",
                column: "joopJoobId",
                principalTable: "joops",
                principalColumn: "JoobId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_customers_joops_joopJoobId",
                table: "customers");

            migrationBuilder.DropTable(
                name: "joops");

            migrationBuilder.DropIndex(
                name: "IX_customers_joopJoobId",
                table: "customers");

            migrationBuilder.DropColumn(
                name: "JoobId",
                table: "customers");

            migrationBuilder.DropColumn(
                name: "joopJoobId",
                table: "customers");
        }
    }
}
