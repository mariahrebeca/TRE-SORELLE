﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TreSorelle.Data;

#nullable disable

namespace TreSorelle.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20231117140910_criar-banco")]
    partial class criarbanco
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.22")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "fe2ef608-8f5e-42fd-9a6f-6669c607692c",
                            ConcurrencyStamp = "78156905-93ef-4fdc-a475-b5134dd47113",
                            Name = "Administrador",
                            NormalizedName = "ADMINISTRADOR"
                        },
                        new
                        {
                            Id = "80be11d5-c31c-4f7c-b3a7-cc2b5d2cbb0e",
                            ConcurrencyStamp = "d191b415-6cbe-4311-a08c-50136727319e",
                            Name = "Cliente",
                            NormalizedName = "CLIENTE"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("longtext");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "81a72bfa-7fe8-4b2e-826b-5dd3b389a300",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "65eea21f-8616-41ec-9f0d-4608bdfafa51",
                            Email = "admin@tresorelle.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@TRESORELLE.COM",
                            NormalizedUserName = "ADMIN",
                            PasswordHash = "AQAAAAEAACcQAAAAEELwuyP61blSdZO7aZ8c2/rOJDeoiESOphS4yH0fmzd/c4lRqodhB7SP6Qwdx32tGw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "42529914-a0b2-4274-a1cc-29bffd6c4485",
                            TwoFactorEnabled = false,
                            UserName = "Admin"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("RoleId")
                        .HasColumnType("varchar(255)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "81a72bfa-7fe8-4b2e-826b-5dd3b389a300",
                            RoleId = "fe2ef608-8f5e-42fd-9a6f-6669c607692c"
                        },
                        new
                        {
                            UserId = "81a72bfa-7fe8-4b2e-826b-5dd3b389a300",
                            RoleId = "80be11d5-c31c-4f7c-b3a7-cc2b5d2cbb0e"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Value")
                        .HasColumnType("longtext");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("TreSorelle.Models.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("DescricaoResumida")
                        .HasMaxLength(300)
                        .HasColumnType("varchar(300)");

                    b.Property<string>("Foto")
                        .HasMaxLength(300)
                        .HasColumnType("varchar(300)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("varchar(60)");

                    b.Property<byte?>("Nota")
                        .HasColumnType("tinyint unsigned");

                    b.Property<decimal>("Preco")
                        .HasColumnType("decimal(6,2)");

                    b.HasKey("Id");

                    b.ToTable("Produto");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DescricaoResumida = "Cascão vermelho recheado com calda de morango, gelato de morango, calda de morango, morangos frescos e suspiros.",
                            Foto = "/assets/img/menu/img-06.jpg",
                            Nome = "Cascão Amor de Morango",
                            Nota = (byte)5,
                            Preco = 17.00m
                        },
                        new
                        {
                            Id = 2,
                            DescricaoResumida = "Cascão de cacau recheado com Nutella, gelato de chocolate, calda de chocolate, granule de chocolate, brownie bites e canudinho de chocolate.",
                            Foto = "/assets/img/menu/img-02.jpg",
                            Nome = "Cascão Chocolatudo",
                            Nota = (byte)5,
                            Preco = 20.00m
                        },
                        new
                        {
                            Id = 3,
                            DescricaoResumida = "Cascão de cacau recheado com beijinho cremoso, gelato de chocolate, calda de chocolate, granule de chocolate e beijinhos",
                            Foto = "/assets/img/menu/img-03.jpg",
                            Nome = "Cascão Prestígio",
                            Nota = (byte)5,
                            Preco = 19.00m
                        },
                        new
                        {
                            Id = 4,
                            DescricaoResumida = "Cascão tradicional recheado com curd de maracujá, gelato de leite, curd de maracujá, granule de chocolate branco e merengue maçaricado.",
                            Foto = "/assets/img/menu/img-04.jpg",
                            Nome = "Cascão Maracujá",
                            Nota = (byte)5,
                            Preco = 19.00m
                        },
                        new
                        {
                            Id = 5,
                            DescricaoResumida = "Cascão verde recheado com curd de limão, gelato de leite, curd de limão, farofa de biscoito, merengue maçaricado e raspas de limão.",
                            Foto = "/assets/img/menu/img-05.jpg",
                            Nome = "Cascão Torta de Limão",
                            Nota = (byte)5,
                            Preco = 17.00m
                        },
                        new
                        {
                            Id = 6,
                            DescricaoResumida = "Cascão de cacau black, recheado com calda de chocolate, gelato de leite, calda de chocolate, farofa Negresco e mini Oreo.",
                            Foto = "/assets/img/menu/img-01.jpg",
                            Nome = "Cascão Cookies'n Cream",
                            Nota = (byte)5,
                            Preco = 17.00m
                        },
                        new
                        {
                            Id = 7,
                            DescricaoResumida = "Casquinha Marvi, gelato (leite, chocolate ou morango), mini Oreo e confeito.",
                            Foto = "/assets/img/menu/img-08.jpg",
                            Nome = "Casquinha Kids",
                            Nota = (byte)5,
                            Preco = 13.00m
                        },
                        new
                        {
                            Id = 8,
                            DescricaoResumida = "Gelato de leite, calda de chocolate e Ovomaltine.",
                            Foto = "/assets/img/menu/img-07.jpg",
                            Nome = "MilkShake de Ovomaltine",
                            Nota = (byte)5,
                            Preco = 15.00m
                        },
                        new
                        {
                            Id = 9,
                            DescricaoResumida = "Gelato de leite, calda de caramelo e farinha láctea.",
                            Foto = "/assets/img/menu/img-16.jpg",
                            Nome = "MilkShake de Farinha Láctea",
                            Nota = (byte)5,
                            Preco = 15.00m
                        },
                        new
                        {
                            Id = 10,
                            DescricaoResumida = "Gelato de leite, calda de caramelo e farofa de paçoca.",
                            Foto = "/assets/img/menu/img-17.jpg",
                            Nome = "MilkShake de Paçoca",
                            Nota = (byte)5,
                            Preco = 15.00m
                        },
                        new
                        {
                            Id = 11,
                            DescricaoResumida = "Gelato de chocolate e calda de morango em dobro.",
                            Foto = "/assets/img/menu/img-09.jpg",
                            Nome = "MilkShake de Sensação",
                            Nota = (byte)5,
                            Preco = 15.00m
                        },
                        new
                        {
                            Id = 12,
                            DescricaoResumida = "Gelato de leite, doce de leite argentino, banana, chantilly, finalizado com cacau em pó.",
                            Foto = "/assets/img/menu/img-16.jpg",
                            Nome = "MilkShake de Banoffe",
                            Nota = (byte)5,
                            Preco = 17.00m
                        },
                        new
                        {
                            Id = 13,
                            DescricaoResumida = "Gelato de leite, calda de caramelo, café, chantilly, finalizado com canela.",
                            Foto = "/assets/img/menu/img-15.jpg",
                            Nome = "MilkShake de Café",
                            Nota = (byte)5,
                            Preco = 17.00m
                        },
                        new
                        {
                            Id = 14,
                            DescricaoResumida = "Gelato de morango, calda de morango e chantilly.",
                            Foto = "/assets/img/menu/img-09.jpg",
                            Nome = "MilkShake de Morango",
                            Nota = (byte)5,
                            Preco = 18.00m
                        },
                        new
                        {
                            Id = 15,
                            DescricaoResumida = "Gelato de leite, calda de chocolate e Nutella.",
                            Foto = "/assets/img/menu/img-15.jpg",
                            Nome = "MilkShake de Nutella",
                            Nota = (byte)5,
                            Preco = 18.00m
                        },
                        new
                        {
                            Id = 16,
                            DescricaoResumida = "Gelato de leite, calda de caramelo, creme de macadâmia e macadâmia caramelizada.",
                            Foto = "/assets/img/menu/img-16.jpg",
                            Nome = "MilkShake de Macadâmia",
                            Nota = (byte)5,
                            Preco = 18.00m
                        },
                        new
                        {
                            Id = 17,
                            DescricaoResumida = "Gelato de leite, calda de chocolate, Nutella e Leite Ninho.",
                            Foto = "/assets/img/menu/img-17.jpg",
                            Nome = "MilkShake de Ninho com Nutella",
                            Nota = (byte)5,
                            Preco = 19.00m
                        },
                        new
                        {
                            Id = 18,
                            DescricaoResumida = "Gelato de pistache, gelato de leite e ganache de pistache.",
                            Foto = "/assets/img/menu/img-18.jpg",
                            Nome = "MilkShake de Pistache",
                            Nota = (byte)5,
                            Preco = 22.00m
                        },
                        new
                        {
                            Id = 19,
                            DescricaoResumida = "Cookie caseiro, crocante por fora e macio por dentro.",
                            Foto = "/assets/img/menu/img-19.jpg",
                            Nome = "Cookie",
                            Nota = (byte)5,
                            Preco = 8.00m
                        },
                        new
                        {
                            Id = 20,
                            DescricaoResumida = "Brownie caseiro com casquinha crocante e macio por dentro.",
                            Foto = "/assets/img/menu/img-20.jpg",
                            Nome = "Brownie",
                            Nota = (byte)5,
                            Preco = 6.00m
                        },
                        new
                        {
                            Id = 21,
                            DescricaoResumida = "Mini bolo de cenoura caseiro, super macio.",
                            Foto = "/assets/img/menu/img-21.jpg",
                            Nome = "Bolo de Cenoura",
                            Nota = (byte)5,
                            Preco = 5.00m
                        },
                        new
                        {
                            Id = 22,
                            DescricaoResumida = "Mini bolo de chocolate caseiro, super macio.",
                            Foto = "/assets/img/menu/img-22.jpg",
                            Nome = "Bolo de Chocolate",
                            Nota = (byte)5,
                            Preco = 5.00m
                        },
                        new
                        {
                            Id = 23,
                            DescricaoResumida = "Croissant caseiro, crocante por fora e macio por dentro.",
                            Foto = "/assets/img/menu/img-23.jpg",
                            Nome = "Croissant Tradicional",
                            Nota = (byte)5,
                            Preco = 9.00m
                        },
                        new
                        {
                            Id = 24,
                            DescricaoResumida = "Croissant caseiro recheado. Consulte os sabores disponíveis.",
                            Foto = "/assets/img/menu/img-25.jpg",
                            Nome = "Croissant Sanduíche",
                            Nota = (byte)5,
                            Preco = 17.00m
                        },
                        new
                        {
                            Id = 25,
                            DescricaoResumida = "Croissant caseiro, recheado com Nutella e morangos.",
                            Foto = "/assets/img/menu/img-25.jpg",
                            Nome = "Croissant Nutella",
                            Nota = (byte)5,
                            Preco = 20.00m
                        },
                        new
                        {
                            Id = 26,
                            DescricaoResumida = "Croissant caseiro, recheado com banana e doce de leite.",
                            Foto = "/assets/img/menu/img-23.jpg",
                            Nome = "Croissant Banoffe",
                            Nota = (byte)5,
                            Preco = 20.00m
                        },
                        new
                        {
                            Id = 27,
                            DescricaoResumida = "Cappuccino tradicional feito na hora.",
                            Foto = "/assets/img/menu/img-32.jpg",
                            Nome = "Cappuccino",
                            Nota = (byte)5,
                            Preco = 10.00m
                        },
                        new
                        {
                            Id = 28,
                            DescricaoResumida = "Refrigerante lata.",
                            Foto = "/assets/img/menu/img-29.jpg",
                            Nome = "Refrigerantes",
                            Nota = (byte)5,
                            Preco = 6.00m
                        },
                        new
                        {
                            Id = 29,
                            DescricaoResumida = "Café expresso feito na hora.",
                            Foto = "/assets/img/menu/img-30.jpg",
                            Nome = "Café Expresso",
                            Nota = (byte)5,
                            Preco = 5.00m
                        },
                        new
                        {
                            Id = 30,
                            DescricaoResumida = "Chocolate Quente cremoso.",
                            Foto = "/assets/img/menu/img-28.jpg",
                            Nome = "Chocolate Quente",
                            Nota = (byte)5,
                            Preco = 10.00m
                        },
                        new
                        {
                            Id = 31,
                            DescricaoResumida = "Crema Café feito na hora.",
                            Foto = "/assets/img/menu/img-32.jpg",
                            Nome = "Crema Café",
                            Nota = (byte)5,
                            Preco = 8.00m
                        },
                        new
                        {
                            Id = 32,
                            DescricaoResumida = "Água mineral com ou sem gás.",
                            Foto = "/assets/img/menu/img-27.jpg",
                            Nome = "Água Mineral",
                            Nota = (byte)5,
                            Preco = 3.00m
                        });
                });

            modelBuilder.Entity("TreSorelle.Models.ProdutoAvaliacao", b =>
                {
                    b.Property<int>("ProdutoId")
                        .HasColumnType("int")
                        .HasColumnOrder(1);

                    b.Property<string>("UsuarioId")
                        .HasColumnType("varchar(255)")
                        .HasColumnOrder(2);

                    b.Property<DateTime>("AvaliacaoData")
                        .HasColumnType("datetime(6)");

                    b.Property<byte?>("ProdutoNota")
                        .HasColumnType("tinyint unsigned");

                    b.HasKey("ProdutoId", "UsuarioId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("ProdutoAvaliacao");
                });

            modelBuilder.Entity("TreSorelle.Models.Tipo", b =>
                {
                    b.Property<byte>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint unsigned");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Tipo");

                    b.HasData(
                        new
                        {
                            Id = (byte)1,
                            Nome = "Casquinha"
                        },
                        new
                        {
                            Id = (byte)2,
                            Nome = "MilkShake"
                        },
                        new
                        {
                            Id = (byte)3,
                            Nome = "Sobremesa"
                        },
                        new
                        {
                            Id = (byte)4,
                            Nome = "Croissant"
                        },
                        new
                        {
                            Id = (byte)5,
                            Nome = "Bebida"
                        });
                });

            modelBuilder.Entity("TreSorelle.Models.Usuario", b =>
                {
                    b.Property<string>("UsuarioId")
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Foto")
                        .HasMaxLength(300)
                        .HasColumnType("varchar(300)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("varchar(60)");

                    b.HasKey("UsuarioId");

                    b.ToTable("Usuario");

                    b.HasData(
                        new
                        {
                            UsuarioId = "81a72bfa-7fe8-4b2e-826b-5dd3b389a300",
                            DataNascimento = new DateTime(2005, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Foto = "/images/usuarios/avatar.png",
                            Nome = "Maria Luiza Gonçalves da Silva"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TreSorelle.Models.ProdutoAvaliacao", b =>
                {
                    b.HasOne("TreSorelle.Models.Produto", "Produto")
                        .WithMany("Avaliacoes")
                        .HasForeignKey("ProdutoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TreSorelle.Models.Usuario", "Usuario")
                        .WithMany("Avaliacoes")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Produto");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("TreSorelle.Models.Usuario", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "AccountUser")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AccountUser");
                });

            modelBuilder.Entity("TreSorelle.Models.Produto", b =>
                {
                    b.Navigation("Avaliacoes");
                });

            modelBuilder.Entity("TreSorelle.Models.Usuario", b =>
                {
                    b.Navigation("Avaliacoes");
                });
#pragma warning restore 612, 618
        }
    }
}
