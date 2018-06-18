using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace API.Migrations
{
    public partial class Update008 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "KeyID",
                table: "eDm_NhomKH",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddUniqueConstraint(
                name: "AK_eDm_NhomKH_KeyID",
                table: "eDm_NhomKH",
                column: "KeyID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropUniqueConstraint(
                name: "AK_eDm_NhomKH_KeyID",
                table: "eDm_NhomKH");

            migrationBuilder.DropColumn(
                name: "KeyID",
                table: "eDm_NhomKH");
        }
    }
}
