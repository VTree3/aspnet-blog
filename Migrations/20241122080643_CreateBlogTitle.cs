using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlogTest3.Migrations
{
    /// <inheritdoc />
    public partial class CreateBlogTitle : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BlogTitle",
                table: "Blog",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BlogTitle",
                table: "Blog");
        }
    }
}
