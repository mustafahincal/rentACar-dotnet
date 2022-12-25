﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class mig3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "Cars");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 32, 121, 183, 65, 111, 191, 30, 242, 246, 124, 20, 81, 25, 214, 238, 0, 102, 24, 157, 183, 146, 16, 148, 225, 216, 160, 150, 20, 9, 135, 49, 76, 145, 32, 189, 96, 178, 62, 197, 165, 0, 145, 191, 67, 141, 3, 182, 158, 31, 119, 35, 80, 156, 184, 158, 241, 95, 204, 110, 36, 191, 45, 199, 187 }, new byte[] { 223, 172, 210, 120, 45, 33, 129, 152, 233, 32, 128, 108, 188, 184, 127, 64, 203, 255, 212, 6, 93, 142, 255, 67, 46, 5, 69, 238, 38, 75, 72, 123, 177, 41, 244, 232, 103, 126, 251, 134, 0, 166, 39, 56, 29, 117, 28, 251, 142, 142, 190, 81, 71, 102, 8, 226, 128, 62, 167, 215, 121, 51, 221, 118, 184, 43, 156, 210, 15, 36, 35, 84, 41, 127, 95, 41, 64, 130, 62, 235, 186, 83, 114, 172, 110, 190, 239, 93, 58, 83, 154, 32, 76, 238, 112, 95, 198, 138, 62, 249, 232, 52, 18, 119, 218, 48, 167, 212, 236, 176, 116, 39, 38, 213, 123, 106, 238, 37, 71, 17, 155, 122, 202, 52, 195, 249, 219, 69 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 243, 124, 94, 207, 77, 244, 122, 245, 177, 206, 220, 2, 246, 153, 44, 33, 51, 129, 210, 102, 94, 241, 115, 240, 106, 250, 169, 107, 78, 210, 137, 237, 58, 187, 103, 161, 111, 24, 235, 71, 61, 81, 11, 122, 85, 63, 135, 208, 145, 131, 63, 228, 194, 153, 149, 185, 133, 98, 2, 64, 149, 211, 38, 117 }, new byte[] { 179, 102, 125, 249, 120, 233, 127, 24, 154, 200, 94, 64, 147, 56, 199, 177, 19, 171, 223, 72, 184, 65, 174, 142, 45, 20, 28, 225, 190, 95, 113, 63, 25, 19, 5, 149, 224, 68, 35, 63, 48, 25, 73, 225, 17, 240, 37, 237, 216, 185, 212, 130, 9, 140, 220, 123, 115, 183, 28, 205, 252, 137, 37, 166, 147, 88, 59, 78, 156, 230, 28, 122, 166, 36, 222, 17, 41, 25, 12, 212, 191, 63, 109, 98, 9, 70, 62, 197, 109, 165, 116, 156, 6, 185, 93, 41, 9, 66, 254, 213, 119, 186, 152, 86, 38, 211, 205, 171, 49, 180, 93, 168, 199, 169, 138, 148, 107, 220, 36, 180, 229, 122, 197, 231, 81, 53, 181, 206 } });
        }
    }
}
