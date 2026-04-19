using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AmericanAirlinesApi.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Aeronaveld",
                table: "Voos",
                newName: "AeronaveId");

            migrationBuilder.RenameColumn(
                name: "Voold",
                table: "Reservas",
                newName: "VooId");

            migrationBuilder.CreateIndex(
                name: "IX_Voos_AeronaveId",
                table: "Voos",
                column: "AeronaveId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservas_VooId",
                table: "Reservas",
                column: "VooId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservas_Voos_VooId",
                table: "Reservas",
                column: "VooId",
                principalTable: "Voos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Voos_Aeronaves_AeronaveId",
                table: "Voos",
                column: "AeronaveId",
                principalTable: "Aeronaves",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservas_Voos_VooId",
                table: "Reservas");

            migrationBuilder.DropForeignKey(
                name: "FK_Voos_Aeronaves_AeronaveId",
                table: "Voos");

            migrationBuilder.DropIndex(
                name: "IX_Voos_AeronaveId",
                table: "Voos");

            migrationBuilder.DropIndex(
                name: "IX_Reservas_VooId",
                table: "Reservas");

            migrationBuilder.RenameColumn(
                name: "AeronaveId",
                table: "Voos",
                newName: "Aeronaveld");

            migrationBuilder.RenameColumn(
                name: "VooId",
                table: "Reservas",
                newName: "Voold");
        }
    }
}
