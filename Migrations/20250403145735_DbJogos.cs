﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoDeJogos.Migrations
{
    /// <inheritdoc />
    public partial class DbJogos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Jogo",
                columns: table => new
                {
                    JogoID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NomeDoJogo = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    Plataforma = table.Column<string>(type: "VARCHAR(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jogo", x => x.JogoID);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    UsuarioID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    NickName = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    JogoFavorito = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.UsuarioID);
                    table.ForeignKey(
                        name: "FK_Usuario_Jogo_JogoFavorito",
                        column: x => x.JogoFavorito,
                        principalTable: "Jogo",
                        principalColumn: "JogoID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Jogo_NomeDoJogo",
                table: "Jogo",
                column: "NomeDoJogo",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_JogoFavorito",
                table: "Usuario",
                column: "JogoFavorito");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_NickName",
                table: "Usuario",
                column: "NickName",
                unique: true,
                filter: "[NickName] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Jogo");
        }
    }
}
