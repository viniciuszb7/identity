using Microsoft.AspNetCore.Identity;

namespace identity.Models
{
    public class UsuariosAplicacao : IdentityUser
    {
        public UsuariosAplicacao() : base()
        {
        }

        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public int Idade { get; set; }
    }
}