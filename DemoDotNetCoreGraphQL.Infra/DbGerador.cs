using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace DemoDotNetCoreGraphQL.Infra
{
    public class DbGerador
    {
        /// <summary>
        /// Inicia banco em memória
        /// </summary>
        public static void Iniciar(IServiceProvider serviceProvider)
        {
            using (var contexto = new DataContext(serviceProvider.GetRequiredService<DbContextOptions<DataContext>>()))
            {
                if (contexto.Clientes.Any())
                {
                    return;   // Dados ja foram providos
                }

                contexto.Clientes.AddRange(
                    new Cliente()
                    {
                        Id = 1,
                        Nome = "Maria",
                        Sobrenome = "Albuquerque",
                        Endereco = "Rua padre jose maria deman 33",
                        Telefone = "31999995555",
                        Email = "maria@teste.com.br"
                    },
                     new Cliente()
                     {
                         Id = 2,
                         Nome = "Ingrid",
                         Sobrenome = "Alencar",
                         Endereco = "Rua paulo piedade campos 850",
                         Telefone = "31999995555",
                         Email = "ingrid@teste.com.br"
                     }
                    );
                contexto.SaveChanges();
            }
        }
    }
}
