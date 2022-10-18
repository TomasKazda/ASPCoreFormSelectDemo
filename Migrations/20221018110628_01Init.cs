using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASPCoreFormSelectDemo.Migrations
{
    public partial class _01Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CodeBook",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CodeBook", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    HumanId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EyeColorId = table.Column<int>(type: "int", nullable: false),
                    ShoeSize = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.HumanId);
                    table.ForeignKey(
                        name: "FK_People_CodeBook_EyeColorId",
                        column: x => x.EyeColorId,
                        principalTable: "CodeBook",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "CodeBook",
                columns: new[] { "Id", "Color" },
                values: new object[,]
                {
                    { 1, "Red" },
                    { 2, "Gray" },
                    { 3, "Blue" },
                    { 4, "Brown" },
                    { 5, "Green" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_People_EyeColorId",
                table: "People",
                column: "EyeColorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "People");

            migrationBuilder.DropTable(
                name: "CodeBook");
        }
    }
}
