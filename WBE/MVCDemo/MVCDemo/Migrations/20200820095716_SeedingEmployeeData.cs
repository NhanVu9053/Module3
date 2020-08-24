using Microsoft.EntityFrameworkCore.Migrations;

namespace MVCDemo.Migrations
{
    public partial class SeedingEmployeeData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "AvatarPath", "Department", "Email", "FullName" },
                values: new object[,]
                {
                    { 1, "~/images/captian.png", 0, "nhanvu@gmail.com", "Captain America" },
                    { 2, "~/images/hulk.png", 1, "tramphan@gmail.com", "Hulk" },
                    { 3, "~/images/ironmanchibi.jpg", 0, "nhungnguyen@gmail.com", "Iron Man" },
                    { 4, "~/images/spidermanchibi.jpg", 1, "quanvu@gmail.com", "Spider Man" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
