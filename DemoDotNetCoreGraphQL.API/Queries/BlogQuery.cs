using DemoDotNetCoreGraphQL.Infra;
using GraphQL.Types;

namespace DemoDotNetCoreGraphQL.API
{
    public class BlogQuery : ObjectGraphType<object>
    {
        public BlogQuery(ClienteRepositorioRepositorio repositorio)
        {
            Field<ListGraphType<ClienteType>>("cliente",
                arguments: new QueryArguments(new QueryArgument[]
                {
                    new QueryArgument<IdGraphType>{Name="id"},
                    new QueryArgument<StringGraphType>{Name="nome"}
                }),
                resolve: contexto =>
                {
                    var filtro = new ClienteFiltro()
                    {
                        Id = contexto.GetArgument<int>("id"),
                        Nome = contexto.GetArgument<string>("nome"),
                    };
                    return repositorio.ObterClientes(filtro);
                }
                
                );
        }
    }
}
