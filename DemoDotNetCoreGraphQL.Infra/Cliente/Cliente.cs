using System;
using System.Collections.Generic;

namespace DemoDotNetCoreGraphQL.Infra
{
    public class Cliente
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Sobrenome { get; set; }

        public string Endereco { get; set; }

        public string Telefone { get; set; }

        public string Email { get; set; }

    }
}
