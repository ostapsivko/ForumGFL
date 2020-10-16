using Microsoft.EntityFrameworkCore.Migrations;

namespace ForumGFL.Migrations
{
    public partial class TopicWithoutBody : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TopicBody",
                table: "Topics");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TopicBody",
                table: "Topics",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
