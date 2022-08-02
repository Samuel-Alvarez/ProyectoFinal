using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyLottoRewards.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    UserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    PasswordHash = table.Column<string>(type: "TEXT", nullable: true),
                    SecurityStamp = table.Column<string>(type: "TEXT", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ganancia",
                columns: table => new
                {
                    GananciaId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Monto = table.Column<int>(type: "INTEGER", nullable: false),
                    NombreLoteria = table.Column<string>(type: "TEXT", nullable: true),
                    TipoJugada = table.Column<string>(type: "TEXT", nullable: true),
                    TotalGanancia = table.Column<double>(type: "REAL", nullable: false),
                    TotalMonto = table.Column<double>(type: "REAL", nullable: false),
                    Fecha = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Loteria = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ganancia", x => x.GananciaId);
                });

            migrationBuilder.CreateTable(
                name: "Loteria",
                columns: table => new
                {
                    LoteriaId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NombreLoteria = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Loteria", x => x.LoteriaId);
                });

            migrationBuilder.CreateTable(
                name: "Ticket",
                columns: table => new
                {
                    TicketId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Fecha = table.Column<DateTime>(type: "TEXT", nullable: false),
                    TipoJugada = table.Column<string>(type: "TEXT", nullable: true),
                    Loteria = table.Column<string>(type: "TEXT", nullable: true),
                    NombreLoteria = table.Column<string>(type: "TEXT", nullable: true),
                    TotalMonto = table.Column<double>(type: "REAL", nullable: false),
                    Monto = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ticket", x => x.TicketId);
                });

            migrationBuilder.CreateTable(
                name: "TipoJugada",
                columns: table => new
                {
                    TipoJugadaId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NombreJugada = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoJugada", x => x.TipoJugadaId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "TEXT", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "TEXT", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "TEXT", nullable: true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    LoginProvider = table.Column<string>(type: "TEXT", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GananciasDetalle",
                columns: table => new
                {
                    DetalleId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    GananciaId = table.Column<int>(type: "INTEGER", nullable: false),
                    LoteriaId = table.Column<int>(type: "INTEGER", nullable: false),
                    TipoJugadaId = table.Column<int>(type: "INTEGER", nullable: false),
                    TotalGanancia = table.Column<double>(type: "REAL", nullable: false),
                    TotalMonto = table.Column<double>(type: "REAL", nullable: false),
                    Ganancias = table.Column<int>(type: "INTEGER", nullable: false),
                    Monto = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GananciasDetalle", x => x.DetalleId);
                    table.ForeignKey(
                        name: "FK_GananciasDetalle_Ganancia_GananciaId",
                        column: x => x.GananciaId,
                        principalTable: "Ganancia",
                        principalColumn: "GananciaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TicketsDetalle",
                columns: table => new
                {
                    DetalleId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TicketId = table.Column<int>(type: "INTEGER", nullable: false),
                    LoteriaId = table.Column<int>(type: "INTEGER", nullable: false),
                    TipoJugadaId = table.Column<int>(type: "INTEGER", nullable: false),
                    TotalMonto = table.Column<double>(type: "REAL", nullable: false),
                    Monto = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TicketsDetalle", x => x.DetalleId);
                    table.ForeignKey(
                        name: "FK_TicketsDetalle_Ticket_TicketId",
                        column: x => x.TicketId,
                        principalTable: "Ticket",
                        principalColumn: "TicketId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Loteria",
                columns: new[] { "LoteriaId", "NombreLoteria" },
                values: new object[] { 1, "Quiniela Loteka" });

            migrationBuilder.InsertData(
                table: "Loteria",
                columns: new[] { "LoteriaId", "NombreLoteria" },
                values: new object[] { 2, "Loteria Nacional" });

            migrationBuilder.InsertData(
                table: "Loteria",
                columns: new[] { "LoteriaId", "NombreLoteria" },
                values: new object[] { 3, "Quiniela Leidsa" });

            migrationBuilder.InsertData(
                table: "Loteria",
                columns: new[] { "LoteriaId", "NombreLoteria" },
                values: new object[] { 4, "Quiniela Real" });

            migrationBuilder.InsertData(
                table: "Loteria",
                columns: new[] { "LoteriaId", "NombreLoteria" },
                values: new object[] { 5, "La Primera" });

            migrationBuilder.InsertData(
                table: "Loteria",
                columns: new[] { "LoteriaId", "NombreLoteria" },
                values: new object[] { 6, "Pega 3 mas" });

            migrationBuilder.InsertData(
                table: "Loteria",
                columns: new[] { "LoteriaId", "NombreLoteria" },
                values: new object[] { 7, "Loto Pool" });

            migrationBuilder.InsertData(
                table: "Loteria",
                columns: new[] { "LoteriaId", "NombreLoteria" },
                values: new object[] { 8, "Loto - Loto Mas" });

            migrationBuilder.InsertData(
                table: "Loteria",
                columns: new[] { "LoteriaId", "NombreLoteria" },
                values: new object[] { 9, "Loto Real" });

            migrationBuilder.InsertData(
                table: "Loteria",
                columns: new[] { "LoteriaId", "NombreLoteria" },
                values: new object[] { 10, "Gana Mas" });

            migrationBuilder.InsertData(
                table: "TipoJugada",
                columns: new[] { "TipoJugadaId", "NombreJugada" },
                values: new object[] { 1, "Pale" });

            migrationBuilder.InsertData(
                table: "TipoJugada",
                columns: new[] { "TipoJugadaId", "NombreJugada" },
                values: new object[] { 2, "Tripleta" });

            migrationBuilder.InsertData(
                table: "TipoJugada",
                columns: new[] { "TipoJugadaId", "NombreJugada" },
                values: new object[] { 3, "Quiniela" });

            migrationBuilder.InsertData(
                table: "TipoJugada",
                columns: new[] { "TipoJugadaId", "NombreJugada" },
                values: new object[] { 4, "Super pale" });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_GananciasDetalle_GananciaId",
                table: "GananciasDetalle",
                column: "GananciaId");

            migrationBuilder.CreateIndex(
                name: "IX_TicketsDetalle_TicketId",
                table: "TicketsDetalle",
                column: "TicketId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "GananciasDetalle");

            migrationBuilder.DropTable(
                name: "Loteria");

            migrationBuilder.DropTable(
                name: "TicketsDetalle");

            migrationBuilder.DropTable(
                name: "TipoJugada");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Ganancia");

            migrationBuilder.DropTable(
                name: "Ticket");
        }
    }
}
