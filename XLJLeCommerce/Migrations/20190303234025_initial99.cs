﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace XLJLeCommerce.Migrations
{
    public partial class initial99 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TotalPrice",
                table: "ShoppingCartTable");

            migrationBuilder.DropColumn(
                name: "TotalPrice",
                table: "OrderedItemsTable");

            migrationBuilder.AddColumn<decimal>(
                name: "Totalprice",
                table: "OrderTable",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Totalprice",
                table: "OrderTable");

            migrationBuilder.AddColumn<decimal>(
                name: "TotalPrice",
                table: "ShoppingCartTable",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "TotalPrice",
                table: "OrderedItemsTable",
                nullable: false,
                defaultValue: 0m);
        }
    }
}