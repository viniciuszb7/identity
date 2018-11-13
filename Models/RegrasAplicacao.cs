using System;
using Microsoft.AspNetCore.Identity;

namespace identity.Models
{
    public class RegrasAplicacao : IdentityRole
    {
        public DateTime dataCriacao;
        public string descricao;

        public RegrasAplicacao() : base()
        {
        }

        public RegrasAplicacao(string nomeRegra) : base(nomeRegra)
        {
        }

        public RegrasAplicacao(string nomeRegra, string descricao,
                               DateTime dataCriacao) : base(nomeRegra)
        {
            base.Name = nomeRegra;

            this.descricao = descricao;
            this.dataCriacao = dataCriacao;
        }
    }
}