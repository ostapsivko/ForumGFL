using Microsoft.EntityFrameworkCore.Migrations;

namespace ForumGFL.Migrations
{
    public partial class experimental : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ForumMessage_Topics_TopicId",
                table: "ForumMessage");

            migrationBuilder.DropIndex(
                name: "IX_ForumMessage_TopicId",
                table: "ForumMessage");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_ForumMessage_TopicId",
                table: "ForumMessage",
                column: "TopicId");

            migrationBuilder.AddForeignKey(
                name: "FK_ForumMessage_Topics_TopicId",
                table: "ForumMessage",
                column: "TopicId",
                principalTable: "Topics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
