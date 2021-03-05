using DemoDotNetCoreGraphQL.Infra;
using GraphQL.Types;

namespace DemoDotNetCoreGraphQL.API
{
    public class ClienteType : ObjectGraphType<Cliente>
    {
        public ClienteType()
        {
            Name = "Cliente";
            Field(x => x.Id, type: typeof(IdGraphType)).Description("Id Cliente");
            Field(x => x.Nome).Description("Nome do Cliente");
            Field(x => x.Sobrenome).Description("Sobrenome do Cliente");
            Field(x => x.Endereco).Description("Endereco do Cliente");
            Field(x => x.Telefone).Description("Telefone do Cliente");
            Field(x => x.Email).Description("Email do Cliente");
        }
    }
}
