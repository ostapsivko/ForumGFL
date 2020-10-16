using Microsoft.EntityFrameworkCore.Migrations;

namespace ForumGFL.Migrations
{
    public partial class TestMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ForumMessage_Topics_TopicId",
                table: "ForumMessage");

            migrationBuilder.AddColumn<string>(
                name: "TopicBody",
                table: "Topics",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TopicId",
                table: "ForumMessage",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ForumMessage_Topics_TopicId",
                table: "ForumMessage",
                column: "TopicId",
                principalTable: "Topics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ForumMessage_Topics_TopicId",
                table: "ForumMessage");

            migrationBuilder.DropColumn(
                name: "TopicBody",
                table: "Topics");

            migrationBuilder.AlterColumn<int>(
                name: "TopicId",
                table: "ForumMessage",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_ForumMessage_Topics_TopicId",
                table: "ForumMessage",
                column: "TopicId",
                principalTable: "Topics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
