﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_ModelFirst.Migrations
{
    /// <inheritdoc />
    public partial class Addedcountrypropertytocustomers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Country",
                table: "Customers");
        }
    }
}
