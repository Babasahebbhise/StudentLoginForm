using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KiranAssesment.Migrations
{
    /// <inheritdoc />
    public partial class Second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "StudentName",
                table: "students",
                type: "varchar(300)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext");

            migrationBuilder.AlterColumn<string>(
                name: "Language",
                table: "students",
                type: "varchar(300)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext");

            migrationBuilder.AlterColumn<string>(
                name: "Gender",
                table: "students",
                type: "varchar(300)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "students",
                type: "varchar(300)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(255)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "StudentName",
                table: "students",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(300)");

            migrationBuilder.AlterColumn<string>(
                name: "Language",
                table: "students",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(300)");

            migrationBuilder.AlterColumn<string>(
                name: "Gender",
                table: "students",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(300)");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "students",
                type: "varchar(255)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(300)");
        }
    }
}
