using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GreenTourism.DAL.Migrations
{
    public partial class added_amenity_group : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Level",
                table: "Comments");

            migrationBuilder.RenameColumn(
                name: "DateAndTime",
                table: "Events",
                newName: "StatDate");

            migrationBuilder.RenameColumn(
                name: "ParentCommentId",
                table: "Comments",
                newName: "ReplyOnId");

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "Events",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Comments",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "AmenityGroupId",
                table: "Amenities",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "AmenityGroups",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AmenityGroups", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Amenities_AmenityGroupId",
                table: "Amenities",
                column: "AmenityGroupId");

            migrationBuilder.AddForeignKey(
                name: "FK_Amenities_AmenityGroups_AmenityGroupId",
                table: "Amenities",
                column: "AmenityGroupId",
                principalTable: "AmenityGroups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Amenities_AmenityGroups_AmenityGroupId",
                table: "Amenities");

            migrationBuilder.DropTable(
                name: "AmenityGroups");

            migrationBuilder.DropIndex(
                name: "IX_Amenities_AmenityGroupId",
                table: "Amenities");

            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "AmenityGroupId",
                table: "Amenities");

            migrationBuilder.RenameColumn(
                name: "StatDate",
                table: "Events",
                newName: "DateAndTime");

            migrationBuilder.RenameColumn(
                name: "ReplyOnId",
                table: "Comments",
                newName: "ParentCommentId");

            migrationBuilder.AddColumn<int>(
                name: "Level",
                table: "Comments",
                nullable: false,
                defaultValue: 0);
        }
    }
}
