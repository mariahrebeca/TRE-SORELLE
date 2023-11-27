using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using TreSorelle.Models;

namespace TreSorelle.Data;

public class AppDbSeed
{
    public AppDbSeed(ModelBuilder builder)
    {
        #region Populate Tipo
        List<Tipo> tipos = new() {
            new Tipo() {
                Id = 1,
                Nome = "Casquinha",
            },
            new Tipo() {
                Id = 2,
                Nome = "MilkShake",
            },
            new Tipo() {
                Id = 3,
                Nome = "Sobremesa",
            },
            new Tipo() {
                Id = 4,
                Nome = "Croissant",
            },
            new Tipo() {
                Id = 5,
                Nome = "Bebida",
            },
        };

        builder.Entity<Tipo>().HasData(tipos);
        #endregion


        #region Populate Produtos
        List<Produto> produtos = new() {
                new Produto() {
                Id = 1,
                Nome = "Cascão Amor de Morango",
                DescricaoResumida = "Cascão vermelho recheado com calda de morango, gelato de morango, calda de morango, morangos frescos e suspiros.",
                Preco = 17.00M,
                Foto = @"/assets/img/menu/img-06.jpg",
                Nota = 5,
            },
                new Produto() {
                Id = 2,
                Nome = "Cascão Chocolatudo",
                DescricaoResumida = "Cascão de cacau recheado com Nutella, gelato de chocolate, calda de chocolate, granule de chocolate, brownie bites e canudinho de chocolate.",
                Preco = 20.00M,
                Foto = @"/assets/img/menu/img-02.jpg",
                Nota = 5,
            },
                new Produto() {
                Id = 3,
                Nome = "Cascão Prestígio",
                DescricaoResumida = "Cascão de cacau recheado com beijinho cremoso, gelato de chocolate, calda de chocolate, granule de chocolate e beijinhos",
                Preco = 19.00M,
                Foto = @"/assets/img/menu/img-03.jpg",
                Nota = 5,
            },
                new Produto() {
                Id = 4,
                Nome = "Cascão Maracujá",
                DescricaoResumida = "Cascão tradicional recheado com curd de maracujá, gelato de leite, curd de maracujá, granule de chocolate branco e merengue maçaricado.",
                Preco = 19.00M,
                Foto = @"/assets/img/menu/img-04.jpg",
                Nota = 5,
            },
                new Produto() {
                Id = 5,
                Nome = "Cascão Torta de Limão",
                DescricaoResumida = "Cascão verde recheado com curd de limão, gelato de leite, curd de limão, farofa de biscoito, merengue maçaricado e raspas de limão.",
                Preco = 17.00M,
                Foto = @"/assets/img/menu/img-05.jpg",
                Nota = 5,
            },
                new Produto() {
                Id = 6,
                Nome = "Cascão Cookies'n Cream",
                DescricaoResumida = "Cascão de cacau black, recheado com calda de chocolate, gelato de leite, calda de chocolate, farofa Negresco e mini Oreo.",
                Preco = 17.00M,
                Foto = @"/assets/img/menu/img-01.jpg",
                Nota = 5,
            },
                new Produto() {
                Id = 7,
                Nome = "Casquinha Kids",
                DescricaoResumida = "Casquinha Marvi, gelato (leite, chocolate ou morango), mini Oreo e confeito.",
                Preco = 13.00M,
                Foto = @"/assets/img/menu/img-08.jpg",
                Nota = 5,
            },
                new Produto() {
                Id = 8,
                Nome = "MilkShake de Ovomaltine",
                DescricaoResumida = "Gelato de leite, calda de chocolate e Ovomaltine.",
                Preco = 15.00M,
                Foto = @"/assets/img/menu/img-07.jpg",
                Nota = 5,
            },
                new Produto() {
                Id = 9,
                Nome = "MilkShake de Farinha Láctea",
                DescricaoResumida = "Gelato de leite, calda de caramelo e farinha láctea.",
                Preco = 15.00M,
                Foto = @"/assets/img/menu/img-16.jpg",
                Nota = 5,
            },
                new Produto() {
                Id = 10,
                Nome = "MilkShake de Paçoca",
                DescricaoResumida = "Gelato de leite, calda de caramelo e farofa de paçoca.",
                Preco = 15.00M,
                Foto = @"/assets/img/menu/img-17.jpg",
                Nota = 5,
            },
                new Produto() {
                Id = 11,
                Nome = "MilkShake de Sensação",
                DescricaoResumida = "Gelato de chocolate e calda de morango em dobro.",
                Preco = 15.00M,
                Foto = @"/assets/img/menu/img-09.jpg",
                Nota = 5,
            },
                new Produto() {
                Id = 12,
                Nome = "MilkShake de Banoffe",
                DescricaoResumida = "Gelato de leite, doce de leite argentino, banana, chantilly, finalizado com cacau em pó.",
                Preco = 17.00M,
                Foto = @"/assets/img/menu/img-16.jpg",
                Nota = 5,
            },
                new Produto() {
                Id = 13,
                Nome = "MilkShake de Café",
                DescricaoResumida = "Gelato de leite, calda de caramelo, café, chantilly, finalizado com canela.",
                Preco = 17.00M,
                Foto = @"/assets/img/menu/img-15.jpg",
                Nota = 5,
            },
                new Produto() {
                Id = 14,
                Nome = "MilkShake de Morango",
                DescricaoResumida = "Gelato de morango, calda de morango e chantilly.",
                Preco = 18.00M,
                Foto = @"/assets/img/menu/img-09.jpg",
                Nota = 5,
            },
                new Produto() {
                Id = 15,
                Nome = "MilkShake de Nutella",
                DescricaoResumida = "Gelato de leite, calda de chocolate e Nutella.",
                Preco = 18.00M,
                Foto = @"/assets/img/menu/img-15.jpg",
                Nota = 5,
            },
                new Produto() {
                Id = 16,
                Nome = "MilkShake de Macadâmia",
                DescricaoResumida = "Gelato de leite, calda de caramelo, creme de macadâmia e macadâmia caramelizada.",
                Preco = 18.00M,
                Foto = @"/assets/img/menu/img-16.jpg",
                Nota = 5,
            },
                new Produto() {
                Id = 17,
                Nome = "MilkShake de Ninho com Nutella",
                DescricaoResumida = "Gelato de leite, calda de chocolate, Nutella e Leite Ninho.",
                Preco = 19.00M,
                Foto = @"/assets/img/menu/img-17.jpg",
                Nota = 5,
            },
                new Produto() {
                Id = 18,
                Nome = "MilkShake de Pistache",
                DescricaoResumida = "Gelato de pistache, gelato de leite e ganache de pistache.",
                Preco = 22.00M,
                Foto = @"/assets/img/menu/img-18.jpg",
                Nota = 5,
            },
                new Produto() {
                Id = 19,
                Nome = "Cookie",
                DescricaoResumida = "Cookie caseiro, crocante por fora e macio por dentro.",
                Preco = 8.00M,
                Foto = @"/assets/img/menu/img-19.jpg",
                Nota = 5,
            },
                new Produto() {
                Id = 20,
                Nome = "Brownie",
                DescricaoResumida = "Brownie caseiro com casquinha crocante e macio por dentro.",
                Preco = 6.00M,
                Foto = @"/assets/img/menu/img-20.jpg",
                Nota = 5,
            },
                new Produto() {
                Id = 21,
                Nome = "Bolo de Cenoura",
                DescricaoResumida = "Mini bolo de cenoura caseiro, super macio.",
                Preco = 5.00M,
                Foto = @"/assets/img/menu/img-21.jpg",
                Nota = 5,
            },
                new Produto() {
                Id = 22,
                Nome = "Bolo de Chocolate",
                DescricaoResumida = "Mini bolo de chocolate caseiro, super macio.",
                Preco = 5.00M,
                Foto = @"/assets/img/menu/img-22.jpg",
                Nota = 5,
            },
                new Produto() {
                Id = 23,
                Nome = "Croissant Tradicional",
                DescricaoResumida = "Croissant caseiro, crocante por fora e macio por dentro.",
                Preco = 9.00M,
                Foto = @"/assets/img/menu/img-23.jpg",
                Nota = 5,
            },
                new Produto() {
                Id = 24,
                Nome = "Croissant Sanduíche",
                DescricaoResumida = "Croissant caseiro recheado. Consulte os sabores disponíveis.",
                Preco = 17.00M,
                Foto = @"/assets/img/menu/img-25.jpg",
                Nota = 5,
            },
                new Produto() {
                Id = 25,
                Nome = "Croissant Nutella",
                DescricaoResumida = "Croissant caseiro, recheado com Nutella e morangos.",
                Preco = 20.00M,
                Foto = @"/assets/img/menu/img-25.jpg",
                Nota = 5,
            },
                new Produto() {
                Id = 26,
                Nome = "Croissant Banoffe",
                DescricaoResumida = "Croissant caseiro, recheado com banana e doce de leite.",
                Preco = 20.00M,
                Foto = @"/assets/img/menu/img-23.jpg",
                Nota = 5,
            },
                new Produto() {
                Id = 27,
                Nome = "Cappuccino",
                DescricaoResumida = "Cappuccino tradicional feito na hora.",
                Preco = 10.00M,
                Foto = @"/assets/img/menu/img-32.jpg",
                Nota = 5,
            },
                new Produto() {
                Id = 28,
                Nome = "Refrigerantes",
                DescricaoResumida = "Refrigerante lata.",
                Preco = 6.00M,
                Foto = @"/assets/img/menu/img-29.jpg",
                Nota = 5,
            },
                new Produto() {
                Id = 29,
                Nome = "Café Expresso",
                DescricaoResumida = "Café expresso feito na hora.",
                Preco = 5.00M,
                Foto = @"/assets/img/menu/img-30.jpg",
                Nota = 5,
            },
                new Produto() {
                Id = 30,
                Nome = "Chocolate Quente",
                DescricaoResumida = "Chocolate Quente cremoso.",
                Preco = 10.00M,
                Foto = @"/assets/img/menu/img-28.jpg",
                Nota = 5,
            },
                new Produto() {
                Id = 31,
                Nome = "Crema Café",
                DescricaoResumida = "Crema Café feito na hora.",
                Preco = 8.00M,
                Foto = @"/assets/img/menu/img-32.jpg",
                Nota = 5,
            },
                new Produto() {
                Id = 32,
                Nome = "Água Mineral",
                DescricaoResumida = "Água mineral com ou sem gás.",
                Preco = 3.00M,
                Foto = @"/assets/img/menu/img-27.jpg",
                Nota = 5,
            }
        };
        builder.Entity<Produto>().HasData(produtos);


        #region Populate Roles - Perfis de Usuário
        List<IdentityRole> roles = new()
        {
            new IdentityRole()
            {
               Id = Guid.NewGuid().ToString(),
               Name = "Administrador",
               NormalizedName = "ADMINISTRADOR"
            },
            new IdentityRole()
            {
               Id = Guid.NewGuid().ToString(),
               Name = "Cliente",
               NormalizedName = "CLIENTE"
            }
        };
        builder.Entity<IdentityRole>().HasData(roles);
        #endregion

        #region Populate IdentityUser
        List<IdentityUser> users = new(){
            new IdentityUser(){
                Id = Guid.NewGuid().ToString(),
                Email = "admin@tresorelle.com",
                NormalizedEmail = "ADMIN@TRESORELLE.COM",
                UserName = "Admin",
                NormalizedUserName = "ADMIN",
                LockoutEnabled = false,
                EmailConfirmed = true,
            }
        };
        foreach (var user in users)
        {
            PasswordHasher<IdentityUser> pass = new();
            user.PasswordHash = pass.HashPassword(user, "@Tre123");
        }
        builder.Entity<IdentityUser>().HasData(users);

        List<Usuario> usuarios = new(){
            new Usuario(){
                UsuarioId = users[0].Id,
                Nome = "Maria Luiza Gonçalves da Silva",
                DataNascimento = DateTime.Parse("10/08/2005"),
                Foto = "/assets/img/usuarios/avatar.png"
            }
        };
        builder.Entity<Usuario>().HasData(usuarios);
        #endregion

        #region Populate UserRole - Usuário com Perfil
        List<IdentityUserRole<string>> userRoles = new()
        {
            new IdentityUserRole<string>() {
                UserId = users[0].Id,
                RoleId = roles[0].Id
            },
            new IdentityUserRole<string>() {
                UserId = users[0].Id,
                RoleId = roles[1].Id
            }
        };
        builder.Entity<IdentityUserRole<string>>().HasData(userRoles);
        #endregion
    }
    #endregion
};