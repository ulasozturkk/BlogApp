using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class SeedCompleted : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Articles",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(150)",
                oldMaxLength: 150);

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ModifiedBy", "ModifiedDate", "Name", "isDeleted" },
                values: new object[,]
                {
                    { new Guid("19f32511-de5a-4234-99a5-503417225df4"), "Admin Test", new DateTime(2024, 3, 19, 7, 19, 19, 159, DateTimeKind.Utc).AddTicks(9310), null, null, null, null, "visual studip core", false },
                    { new Guid("77ebf623-09be-411f-9165-04dc3ba68d94"), "Admin Test", new DateTime(2024, 3, 19, 7, 19, 19, 159, DateTimeKind.Utc).AddTicks(9300), null, null, null, null, "dotnet core", false }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "FileName", "FileType", "ModifiedBy", "ModifiedDate", "isDeleted" },
                values: new object[,]
                {
                    { new Guid("14b15696-c3b9-4f50-b42e-64455b8ef0dc"), "Admin test", new DateTime(2024, 3, 19, 7, 19, 19, 159, DateTimeKind.Utc).AddTicks(9370), null, null, "images/vstest", "jpg", null, null, false },
                    { new Guid("bd316f53-95cb-48c9-931b-528d141e4e8e"), "Admin test", new DateTime(2024, 3, 19, 7, 19, 19, 159, DateTimeKind.Utc).AddTicks(9370), null, null, "images/testimage", "jpg", null, null, false }
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "ModifiedBy", "ModifiedDate", "Title", "ViewCount", "isDeleted" },
                values: new object[] { new Guid("852e041e-4ed4-43a4-8ee4-91832d978db1"), new Guid("77ebf623-09be-411f-9165-04dc3ba68d94"), "lorem ipsum sdfngjksdfgmdfjsgnsdfglsdfngsdflşkgnsdlfkgnklsdifngşlksdfnglkşsdfngsşdlfkgnskldfgşsldfgsfgsdfgsdfg", "Admin Test", new DateTime(2024, 3, 19, 7, 19, 19, 159, DateTimeKind.Utc).AddTicks(9130), null, null, new Guid("bd316f53-95cb-48c9-931b-528d141e4e8e"), null, null, "dotnet Deneme makalesi 1", 15, false });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("852e041e-4ed4-43a4-8ee4-91832d978db1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("19f32511-de5a-4234-99a5-503417225df4"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("14b15696-c3b9-4f50-b42e-64455b8ef0dc"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("77ebf623-09be-411f-9165-04dc3ba68d94"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("bd316f53-95cb-48c9-931b-528d141e4e8e"));

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Articles",
                type: "character varying(150)",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");
        }
    }
}
