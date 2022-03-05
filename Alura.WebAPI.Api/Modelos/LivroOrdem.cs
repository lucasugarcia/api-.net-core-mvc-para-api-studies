using Alura.ListaLeitura.Modelos;
using System.Linq;
using System.Linq.Dynamic.Core;

namespace Alura.WebAPI.Api.Modelos
{
    public class LivroOrdem
    {
        public string OrdenarPor { get; set; }
    }

    public static class LivroOrdemExtensions
    {
        public static  IQueryable<Livro> AplicarOrdem(this IQueryable<Livro> query, LivroOrdem ordem)
        {
            if(ordem == null)
                return query;

            query = query.OrderBy(ordem.OrdenarPor);
            
            return query;
        }
    }
}
