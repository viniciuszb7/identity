using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

using identity.Models;

namespace identity.Data
{
    public class ApplicationDbContext : IdentityDbContext
                <UsuariosAplicacao, RegrasAplicacao, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
