﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LoanCalculator.Infrastructure.Migrations
{
    public partial class BaseEntityChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "CalculationTypes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "CalculationTypes",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "CalculationTypes");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "CalculationTypes");
        }
    }
}
