using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace layered_Architecture.DataAccess.Migrations
{
    public partial class relation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "abouts",
                columns: table => new
                {
                    aboutID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    aboutDetails1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    aboutDetails2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    aboutİmage1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    aboutİmage2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    aboutMapLocation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    aboutStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_abouts", x => x.aboutID);
                });

            migrationBuilder.CreateTable(
                name: "categories",
                columns: table => new
                {
                    categoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    categoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    categoryDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    categoryStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categories", x => x.categoryId);
                });

            migrationBuilder.CreateTable(
                name: "contacts",
                columns: table => new
                {
                    contactId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    contactUserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    contactMail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    contactSubject = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    contactMassege = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    contactDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    contactBool = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_contacts", x => x.contactId);
                });

            migrationBuilder.CreateTable(
                name: "writers",
                columns: table => new
                {
                    writerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    writerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    writerAbout = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    writerImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    writerMail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    writerPassword = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    writerStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_writers", x => x.writerId);
                });

            migrationBuilder.CreateTable(
                name: "blogs",
                columns: table => new
                {
                    blogId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    blogTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    blogContent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    blogthumbNailİmage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    blogİmage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    blogCreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    blogStatus = table.Column<bool>(type: "bit", nullable: false),
                    categoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_blogs", x => x.blogId);
                    table.ForeignKey(
                        name: "FK_blogs_categories_categoryId",
                        column: x => x.categoryId,
                        principalTable: "categories",
                        principalColumn: "categoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "comments",
                columns: table => new
                {
                    commentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    commentUserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    commentTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    commentContent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    commentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    commentStatus = table.Column<bool>(type: "bit", nullable: false),
                    blogId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_comments", x => x.commentId);
                    table.ForeignKey(
                        name: "FK_comments_blogs_blogId",
                        column: x => x.blogId,
                        principalTable: "blogs",
                        principalColumn: "blogId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_blogs_categoryId",
                table: "blogs",
                column: "categoryId");

            migrationBuilder.CreateIndex(
                name: "IX_comments_blogId",
                table: "comments",
                column: "blogId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "abouts");

            migrationBuilder.DropTable(
                name: "comments");

            migrationBuilder.DropTable(
                name: "contacts");

            migrationBuilder.DropTable(
                name: "writers");

            migrationBuilder.DropTable(
                name: "blogs");

            migrationBuilder.DropTable(
                name: "categories");
        }
    }
}
