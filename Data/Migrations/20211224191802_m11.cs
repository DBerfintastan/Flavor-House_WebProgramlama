using Microsoft.EntityFrameworkCore.Migrations;

namespace FlavorHouse.Data.Migrations
{
    public partial class m11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "carts",
                columns: table => new
                {
                    CartId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DessertName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DessertID = table.Column<int>(type: "int", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    applicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    applicationUser1Id = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Price = table.Column<int>(type: "int", nullable: false),
                    dessert1DessertID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_carts", x => x.CartId);
                    table.ForeignKey(
                        name: "FK_carts_AspNetUsers_applicationUser1Id",
                        column: x => x.applicationUser1Id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_carts_AspNetUsers_applicationUserId",
                        column: x => x.applicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_carts_desserts_dessert1DessertID",
                        column: x => x.dessert1DessertID,
                        principalTable: "desserts",
                        principalColumn: "DessertID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_carts_desserts_DessertID",
                        column: x => x.DessertID,
                        principalTable: "desserts",
                        principalColumn: "DessertID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_carts_applicationUser1Id",
                table: "carts",
                column: "applicationUser1Id");

            migrationBuilder.CreateIndex(
                name: "IX_carts_applicationUserId",
                table: "carts",
                column: "applicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_carts_dessert1DessertID",
                table: "carts",
                column: "dessert1DessertID");

            migrationBuilder.CreateIndex(
                name: "IX_carts_DessertID",
                table: "carts",
                column: "DessertID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "carts");
        }
    }
}
