using System.Threading.Tasks;
using identity.Models;
using Microsoft.AspNetCore.Identity;
using System;

namespace identity.Data
{
    public class PopulaBanco
    {
        public static async Task Initialize(ApplicationDbContext context,
                        UserManager<UsuariosAplicacao> userManager,
                        RoleManager<RegrasAplicacao> roleManager)
        {
            context.Database.EnsureCreated();

            string adminId1 = "";
            string adminId2 = "";

            string papel1 = "Admin";
            string descricao1 = "Administrador do Sistema";

            string papel2 = "User";
            string descricao2 = "Usuario padrão";

            string senha = "teste123";

            // Inclusao do papel 1
            if( await roleManager.FindByNameAsync(papel1) == null){
                await roleManager.CreateAsync(new RegrasAplicacao(papel1, descricao1, DateTime.Now));
            }

            // Inclusao do papel 2
            if( await roleManager.FindByNameAsync(papel2) == null){
                await roleManager.CreateAsync(new RegrasAplicacao(papel2, descricao2, DateTime.Now));
            }

            // Inclusao do usuario 1
            if(await userManager.FindByNameAsync("usuario1") == null){
                var usuario = new UsuariosAplicacao{
                    UserName = "usuario1@teste.com",
                    Email = "usuario1@teste.com",
                    Nome = "Usuário de testes 1",
                    SobreNome = "Teste do sistema",
                    Idade = 25
                };

                var result = await userManager.CreateAsync(usuario);
                if (result.Succeeded){
                    await userManager.AddPasswordAsync(usuario, senha);
                    await userManager.AddToRoleAsync(usuario, papel1);
                }
                adminId1 = usuario.Id;
            }

            if(await userManager.FindByNameAsync("usuario2") == null){
                var usuario = new UsuariosAplicacao{
                    UserName = "usuario2@teste.com",
                    Email = "usuario2@teste.com",
                    Nome = "Usuário de testes 2",
                    SobreNome = "Teste do sistema",
                    Idade = 30
                };

                var result = await userManager.CreateAsync(usuario);
                if (result.Succeeded){
                    await userManager.AddPasswordAsync(usuario, senha);
                    await userManager.AddToRoleAsync(usuario, papel2);
                }
                adminId2 = usuario.Id;
            }
        } 
    }
}