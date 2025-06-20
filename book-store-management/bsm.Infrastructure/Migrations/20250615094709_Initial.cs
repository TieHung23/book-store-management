﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace bsm.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up( MigrationBuilder migrationBuilder )
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<Guid>( type: "uniqueidentifier", nullable: false ),
                    UserName = table.Column<string>( type: "nvarchar(max)", nullable: false ),
                    Password = table.Column<string>( type: "nvarchar(max)", nullable: false ),
                    Email = table.Column<string>( type: "nvarchar(max)", nullable: false ),
                    DateOfBirth = table.Column<DateTime>( type: "datetime2", nullable: false ),
                    Status = table.Column<int>( type: "int", nullable: false )
                },
                constraints: table =>
                {
                    table.PrimaryKey( "PK_Users", x => x.UserId );
                } );
        }

        /// <inheritdoc />
        protected override void Down( MigrationBuilder migrationBuilder )
        {
            migrationBuilder.DropTable(
                name: "Users" );
        }
    }
}
