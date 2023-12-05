using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TreSorelle.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedUserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedEmail = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EmailConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    PasswordHash = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SecurityStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumber = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumberConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Produto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DescricaoResumida = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Foto = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Preco = table.Column<decimal>(type: "decimal(6,2)", nullable: false),
                    Nota = table.Column<byte>(type: "tinyint unsigned", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produto", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Tipo",
                columns: table => new
                {
                    Id = table.Column<byte>(type: "tinyint unsigned", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tipo", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimType = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimValue = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
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
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimType = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimValue = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
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
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProviderKey = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProviderDisplayName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
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
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RoleId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
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
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LoginProvider = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Value = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
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
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    UsuarioId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Nome = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DataNascimento = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Foto = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.UsuarioId);
                    table.ForeignKey(
                        name: "FK_Usuario_AspNetUsers_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ProdutoAvaliacao",
                columns: table => new
                {
                    ProdutoId = table.Column<int>(type: "int", nullable: false),
                    UsuarioId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    AvaliacaoData = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ProdutoNota = table.Column<byte>(type: "tinyint unsigned", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProdutoAvaliacao", x => new { x.ProdutoId, x.UsuarioId });
                    table.ForeignKey(
                        name: "FK_ProdutoAvaliacao_Produto_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "Produto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProdutoAvaliacao_Usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "UsuarioId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5b95f310-4081-4ba3-ba0c-049fc13d65d7", "1c9d9279-954f-48ce-ba09-dc1824e33567", "Cliente", "CLIENTE" },
                    { "be5dea55-8b9c-4d77-93fd-2f6441cbec2b", "68b38ac5-0f99-45cc-a513-b31163ce140f", "Administrador", "ADMINISTRADOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "17b87160-4fa4-46e2-b97c-bd0c64bc24b9", 0, "3d5ee087-a462-4592-82fe-e5c8be6fd936", "admin@tresorelle.com", true, false, null, "ADMIN@TRESORELLE.COM", "ADMIN", "AQAAAAEAACcQAAAAEIMSdZGVJdiMyyuEg5BGmQ2j9TA9mUTa5d3MM2m1TOy7vYqwHh/VU5Bm6YKll9vqTw==", null, false, "52337ee2-28c4-40fc-b535-055fa32d88be", false, "Admin" });

            migrationBuilder.InsertData(
                table: "Produto",
                columns: new[] { "Id", "DescricaoResumida", "Foto", "Nome", "Nota", "Preco" },
                values: new object[,]
                {
                    { 1, "Cascão vermelho recheado com calda de morango, gelato de morango, calda de morango, morangos frescos e suspiros.", "/assets/img/menu/img-06.jpg", "Cascão Amor de Morango", (byte)5, 17.00m },
                    { 2, "Cascão de cacau recheado com Nutella, gelato de chocolate, calda de chocolate, granule de chocolate, brownie bites e canudinho de chocolate.", "/assets/img/menu/img-02.jpg", "Cascão Chocolatudo", (byte)5, 20.00m },
                    { 3, "Cascão de cacau recheado com beijinho cremoso, gelato de chocolate, calda de chocolate, granule de chocolate e beijinhos", "/assets/img/menu/img-03.jpg", "Cascão Prestígio", (byte)5, 19.00m },
                    { 4, "Cascão tradicional recheado com curd de maracujá, gelato de leite, curd de maracujá, granule de chocolate branco e merengue maçaricado.", "/assets/img/menu/img-04.jpg", "Cascão Maracujá", (byte)5, 19.00m },
                    { 5, "Cascão verde recheado com curd de limão, gelato de leite, curd de limão, farofa de biscoito, merengue maçaricado e raspas de limão.", "/assets/img/menu/img-05.jpg", "Cascão Torta de Limão", (byte)5, 17.00m },
                    { 6, "Cascão de cacau black, recheado com calda de chocolate, gelato de leite, calda de chocolate, farofa Negresco e mini Oreo.", "/assets/img/menu/img-01.jpg", "Cascão Cookies'n Cream", (byte)5, 17.00m },
                    { 7, "Casquinha Marvi, gelato (leite, chocolate ou morango), mini Oreo e confeito.", "/assets/img/menu/img-08.jpg", "Casquinha Kids", (byte)5, 13.00m },
                    { 8, "Gelato de leite, calda de chocolate e Ovomaltine.", "/assets/img/menu/img-07.jpg", "MilkShake de Ovomaltine", (byte)5, 15.00m },
                    { 9, "Gelato de leite, calda de caramelo e farinha láctea.", "/assets/img/menu/img-16.jpg", "MilkShake de Farinha Láctea", (byte)5, 15.00m },
                    { 10, "Gelato de leite, calda de caramelo e farofa de paçoca.", "/assets/img/menu/img-17.jpg", "MilkShake de Paçoca", (byte)5, 15.00m },
                    { 11, "Gelato de chocolate e calda de morango em dobro.", "/assets/img/menu/img-09.jpg", "MilkShake de Sensação", (byte)5, 15.00m },
                    { 12, "Gelato de leite, doce de leite argentino, banana, chantilly, finalizado com cacau em pó.", "/assets/img/menu/img-16.jpg", "MilkShake de Banoffe", (byte)5, 17.00m },
                    { 13, "Gelato de leite, calda de caramelo, café, chantilly, finalizado com canela.", "/assets/img/menu/img-15.jpg", "MilkShake de Café", (byte)5, 17.00m },
                    { 14, "Gelato de morango, calda de morango e chantilly.", "/assets/img/menu/img-09.jpg", "MilkShake de Morango", (byte)5, 18.00m },
                    { 15, "Gelato de leite, calda de chocolate e Nutella.", "/assets/img/menu/img-15.jpg", "MilkShake de Nutella", (byte)5, 18.00m },
                    { 16, "Gelato de leite, calda de caramelo, creme de macadâmia e macadâmia caramelizada.", "/assets/img/menu/img-16.jpg", "MilkShake de Macadâmia", (byte)5, 18.00m },
                    { 17, "Gelato de leite, calda de chocolate, Nutella e Leite Ninho.", "/assets/img/menu/img-17.jpg", "MilkShake de Ninho com Nutella", (byte)5, 19.00m },
                    { 18, "Gelato de pistache, gelato de leite e ganache de pistache.", "/assets/img/menu/img-18.jpg", "MilkShake de Pistache", (byte)5, 22.00m },
                    { 19, "Cookie caseiro, crocante por fora e macio por dentro.", "/assets/img/menu/img-19.jpg", "Cookie", (byte)5, 8.00m },
                    { 20, "Brownie caseiro com casquinha crocante e macio por dentro.", "/assets/img/menu/img-20.jpg", "Brownie", (byte)5, 6.00m },
                    { 21, "Mini bolo de cenoura caseiro, super macio.", "/assets/img/menu/img-21.jpg", "Bolo de Cenoura", (byte)5, 5.00m },
                    { 22, "Mini bolo de chocolate caseiro, super macio.", "/assets/img/menu/img-22.jpg", "Bolo de Chocolate", (byte)5, 5.00m },
                    { 23, "Croissant caseiro, crocante por fora e macio por dentro.", "/assets/img/menu/img-23.jpg", "Croissant Tradicional", (byte)5, 9.00m },
                    { 24, "Croissant caseiro recheado. Consulte os sabores disponíveis.", "/assets/img/menu/img-25.jpg", "Croissant Sanduíche", (byte)5, 17.00m },
                    { 25, "Croissant caseiro, recheado com Nutella e morangos.", "/assets/img/menu/img-25.jpg", "Croissant Nutella", (byte)5, 20.00m },
                    { 26, "Croissant caseiro, recheado com banana e doce de leite.", "/assets/img/menu/img-23.jpg", "Croissant Banoffe", (byte)5, 20.00m },
                    { 27, "Cappuccino tradicional feito na hora.", "/assets/img/menu/img-32.jpg", "Cappuccino", (byte)5, 10.00m },
                    { 28, "Refrigerante lata.", "/assets/img/menu/img-29.jpg", "Refrigerantes", (byte)5, 6.00m },
                    { 29, "Café expresso feito na hora.", "/assets/img/menu/img-30.jpg", "Café Expresso", (byte)5, 5.00m },
                    { 30, "Chocolate Quente cremoso.", "/assets/img/menu/img-28.jpg", "Chocolate Quente", (byte)5, 10.00m },
                    { 31, "Crema Café feito na hora.", "/assets/img/menu/img-32.jpg", "Crema Café", (byte)5, 8.00m },
                    { 32, "Água mineral com ou sem gás.", "/assets/img/menu/img-27.jpg", "Água Mineral", (byte)5, 3.00m }
                });

            migrationBuilder.InsertData(
                table: "Tipo",
                columns: new[] { "Id", "Nome" },
                values: new object[,]
                {
                    { (byte)1, "Casquinha" },
                    { (byte)2, "MilkShake" },
                    { (byte)3, "Sobremesa" },
                    { (byte)4, "Croissant" },
                    { (byte)5, "Bebida" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "5b95f310-4081-4ba3-ba0c-049fc13d65d7", "17b87160-4fa4-46e2-b97c-bd0c64bc24b9" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "be5dea55-8b9c-4d77-93fd-2f6441cbec2b", "17b87160-4fa4-46e2-b97c-bd0c64bc24b9" });

            migrationBuilder.InsertData(
                table: "Usuario",
                columns: new[] { "UsuarioId", "DataNascimento", "Foto", "Nome" },
                values: new object[] { "17b87160-4fa4-46e2-b97c-bd0c64bc24b9", new DateTime(2005, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "/assets/img/usuarios/avatar.png", "Maria Luiza Gonçalves da Silva" });

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
                name: "IX_ProdutoAvaliacao_UsuarioId",
                table: "ProdutoAvaliacao",
                column: "UsuarioId");
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
                name: "ProdutoAvaliacao");

            migrationBuilder.DropTable(
                name: "Tipo");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Produto");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
