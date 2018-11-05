using Microsoft.EntityFrameworkCore.Migrations;

namespace AsyncInn.Migrations
{
    public partial class DBSeedUpdate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Rooms",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Amenities",
                columns: new[] { "ID", "HotelRoomHotelID", "HotelRoomRoomNumber", "Name" },
                values: new object[,]
                {
                    { 1, null, null, "Hot Tub" },
                    { 2, null, null, "Heart Shaped Pillows" },
                    { 3, null, null, "Rose Pedals" },
                    { 4, null, null, "Champange Dispensor" },
                    { 5, null, null, "Fluffy Handcuffs" }
                });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "ID",
                keyValue: 2,
                column: "Phone",
                value: "206-666-5555");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "Address", "Name", "Phone" },
                values: new object[] { "111 Rodeo Drive, Seattle, WA 98105", "Ballard", "206-888-5555" });

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "ID", "Address", "Name", "Phone" },
                values: new object[,]
                {
                    { 4, "1526 29th Avenue, Seattle, WA 98122", "Central District", "206-739-9112" },
                    { 5, "200 200th Place SE, Bothell, WA 98012", "Bothell", "425-487-9840" }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "ID", "Layout", "Name" },
                values: new object[,]
                {
                    { 1, 0, "Hawks Nest" },
                    { 2, 0, "Sonics Court" },
                    { 3, 1, "Husky Den" },
                    { 4, 1, "Sounders Club" },
                    { 5, 2, "Storms Court" },
                    { 6, 2, "Dreamin' NHL" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Rooms",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "ID",
                keyValue: 2,
                column: "Phone",
                value: "206-777-5555");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "Address", "Name", "Phone" },
                values: new object[] { "555 55th Place, Seattle, WA 98101", "West Seattle", "206-777-5555" });
        }
    }
}
