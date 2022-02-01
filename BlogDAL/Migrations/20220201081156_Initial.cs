using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogDAL.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Subtitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DatePosted = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ImgPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImgDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Author", "Content", "DatePosted", "ImgDescription", "ImgPath", "Subtitle", "Title" },
                values: new object[,]
                {
                    { 1, "Andrii", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec non mollis nunc. Mauris porta quis mauris at aliquam. Duis consectetur finibus ex id tempor. Etiam maximus enim et tortor scelerisque vestibulum. Sed viverra suscipit risus. Sed turpis risus, faucibus eu ultrices eu, facilisis ac diam. Donec molestie commodo sem hendrerit venenatis. Aliquam viverra orci sapien, sed ultrices tortor dapibus vel.Integer at dignissim erat, ac pulvinar turpis.Nullam tempus finibus quam at bibendum.Duis id risus velit. Cras ultrices, dui et vulputate egestas, sem eros dictum ligula, nec ultricies diam velit vel nisl. Cras rutrum ornare mauris id dignissim. Vivamus vel quam diam. Nulla nisl felis, euismod et cursus sit amet, tristique ac velit.Curabitur ac arcu convallis, dictum nunc a, consectetur neque. Pellentesque ipsum nunc, placerat eu dignissim et, pulvinar at metus.Morbi eget tristique elit,", new DateTime(2022, 1, 22, 10, 11, 53, 930, DateTimeKind.Local).AddTicks(8646), "Img Description 1", "https://picsum.photos/1000/800", "Some subtitle1", "Some title1" },
                    { 2, "Andrii", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec non mollis nunc. Mauris porta quis mauris at aliquam. Duis consectetur finibus ex id tempor. Etiam maximus enim et tortor scelerisque vestibulum. Sed viverra suscipit risus. Sed turpis risus, faucibus eu ultrices eu, facilisis ac diam. Donec molestie commodo sem hendrerit venenatis. Aliquam viverra orci sapien, sed ultrices tortor dapibus vel.Integer at dignissim erat, ac pulvinar turpis.Nullam tempus finibus quam at bibendum.Duis id risus velit. Cras ultrices, dui et vulputate egestas, sem eros dictum ligula, nec ultricies diam velit vel nisl. Cras rutrum ornare mauris id dignissim. Vivamus vel quam diam. Nulla nisl felis, euism", new DateTime(2022, 1, 12, 10, 11, 53, 938, DateTimeKind.Local).AddTicks(9665), "Img Description 2", "https://picsum.photos/1000/800", "Some subtitle2", "Some title2" },
                    { 3, "Andrii", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec non mollis nunc. Mauris porta quis mauris at aliquam. Duis consectetur finibus ex id tempor. Etiam maximus enim et tortor scelerisque vestibulum. Sed viverra suscipit risus. Sed turpis risus, faucibus eu ultrices eu, facilisis ac diam. Donec molestie commodo sem hendrerit venenatis. Aliquam viverra orci sapien, sed ultrices tortor dapibus vel.Integer at dignissim erat, ac pulvinar turpis.Nullam tempus finibus quam at bibendum.Duis id risus velit. Cras ultrices, dui et vulputate egestas, sem eros dictum ligula, nec ultricies diam velit vel nisl. Cras rutrum ornare mauris id dignissim. Vivamus vel quam diam. Nulla nisl felis, euismod et cursus sit amet, tristique ac velit.Curabitur ac arcu convallis, dictum nunc a, consectetur ne", new DateTime(2022, 1, 31, 10, 11, 53, 938, DateTimeKind.Local).AddTicks(9776), "Img Description 3", "https://picsum.photos/1000/800", "Some subtitle3", "Some title3" },
                    { 4, "Andrii", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec non mollis nunc. Mauris porta quis mauris at aliquam. Duis consectetur finibus ex id tempor. Etiam maximus enim et tortor scelerisque vestibulum. Sed viverra suscipit risus. Sed turpis risus, faucibus eu ultrices eu, facilisis ac diam. Donec molestie commodo sem hendrerit venenatis. Aliquam viverra orci sapien, sed ultrices tortor dapibus vel.Integer at dignissim erat, ac pulvinar turpis.Nullam tempus finibus quam at bibendum.Duis id risus velit. Cras ultrices, dui et vulputate egestas, sem eros dictum ligula, nec ultricies diam velit vel nisl. Cras rutrum ornare mauris id dignissim. Vivamus vel quam diam. Nulla nisl felis, euismod et cursus sit amet, tristique ac velit.Curabitur ac arcu convallis, dictum nunc a, consectetur neque. Pellentesque ipsum nunc, placerat eu dignissim et, pulvinar at metus.Morbi eget tristique elit, a maximus lacus.Praesent nibh massa, viverra sit amet mi vel, feugiat ultricies mi.Vivamus feugiat ", new DateTime(2022, 1, 31, 10, 11, 53, 938, DateTimeKind.Local).AddTicks(9796), "Img Description 4", "https://picsum.photos/1000/800", "Some subtitle4", "Some title4" },
                    { 5, "Andrii", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec non mollis nunc. Mauris porta quis mauris at aliquam. Duis consectetur finibus ex id tempor. Etiam maximus enim et tortor scelerisque vestibulum. Sed viverra suscipit risus. Sed turpis risus, faucibus eu ultrices eu, facilisis ac diam. Donec molestie commodo sem hendrerit venenatis. Aliquam viverra orci sapien, sed ultrices tortor dapibus vel.Integer at dignissim erat, ac pulvinar turpis.Nullam tempus finibus quam at bibendum.Duis id risus velit. Cras ultrices, dui et vulputate egestas, sem eros dictum ligula, nec ultricies diam velit vel nisl. Cras rutrum ornare mauris id dignissim. Vivamus vel quam diam. Nulla nisl felis, euismod et cursus sit amet, tristique ac velit.Curabitur ac arcu convallis, dictum nunc a, consectetur neque. Pellentesque ipsum nunc, placerat eu dignissim et, pulvinar at metus.Morbi eget tristique elit,", new DateTime(2022, 1, 22, 10, 11, 53, 938, DateTimeKind.Local).AddTicks(9826), "Img Description 5", "https://picsum.photos/1000/800", "Some subtitle5", "Some title5" },
                    { 6, "Andrii", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec non mollis nunc. Mauris porta quis mauris at aliquam. Duis consectetur finibus ex id tempor. Etiam maximus enim et tortor scelerisque vestibulum. Sed viverra suscipit risus. Sed turpis risus, faucibus eu ultrices eu, facilisis ac diam. Donec molestie commodo sem hendrerit venenatis. Aliquam viverra orci sapien, sed ultrices tortor dapibus vel.Integer at dignissim erat, ac pulvinar turpis.Nullam tempus finibus quam at bibendum.Duis id risus velit. Cras ultrices, dui et vulputate egestas, sem eros dictum ligula, nec ultricies diam velit vel nisl. Cras rutrum ornare mauris id dignissim. Vivamus vel quam diam. Nulla nisl felis, euismod et cursus sit amet, tristique ac velit.Curabitur ac arcu convallis, dictum nunc a, consectetur neque. Pellentesque ipsum nunc, placerat eu dignissim et, pulvinar at metus.Morbi eget tristique elit, a maximus lacus.Praesent nibh massa, viverra sit amet mi vel, feugiat ultricies mi.Vivamus feugiat", new DateTime(2022, 1, 22, 10, 11, 53, 986, DateTimeKind.Local).AddTicks(8092), "Img Description 6", "https://picsum.photos/1000/800", "Some subtitle6", "Some title6" },
                    { 7, "Andrii", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec non mollis nunc. Mauris porta quis mauris at aliquam. Duis consectetur finibus ex id tempor. Etiam maximus enim et tortor scelerisque vestibulum. Sed viverra suscipit risus. Sed turpis risus, faucibus eu ultrices eu, facilisis ac diam. Donec molestie commodo sem hendrerit venenatis. Aliquam viverra orci sapien, sed ultrices tortor dapibus vel.Integer at dignissim erat, ac pulvinar turpis.Nullam tempus finibus quam at bibendum.Duis id risus velit. Cras ultrices, dui et vulputate egestas, sem eros dictum ligula, nec ultricies diam velit vel nisl. Cras rutrum ornare mauris id dignissim. Vivamus vel quam diam. Nulla nisl felis, euismod et cursus sit amet, tristique ac velit.Curabitur ac arcu convallis, dictum nunc a, consectetur ne", new DateTime(2021, 10, 24, 10, 11, 53, 986, DateTimeKind.Local).AddTicks(8190), "Img Description 7", "https://picsum.photos/1000/800", "Some subtitle7", "Some title7" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Posts");
        }
    }
}
