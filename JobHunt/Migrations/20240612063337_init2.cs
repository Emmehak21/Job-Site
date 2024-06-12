using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace jobHunt.Migrations
{
    /// <inheritdoc />
    public partial class init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Login");

            migrationBuilder.CreateTable(
                name: "reg",
                columns: table => new
                {
                    uemail = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    upass = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    upassc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ucountry = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ucity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    uphone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    gender = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_reg", x => x.uemail);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "reg");

            migrationBuilder.CreateTable(
                name: "Login",
                columns: table => new
                {
                    uemail = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    upass = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Login", x => x.uemail);
                });
        }
    }
}
