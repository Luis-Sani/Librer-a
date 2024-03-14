using Microsoft.AspNetCore.Mvc.Rendering;

namespace Libreria.Services
{
    public interface IServicioLista
    {
        Task<IEnumerable<SelectListItem>> GetListaAutores();

        Task<IEnumerable<SelectListItem>>   GetListaCategorias();
    }
}
