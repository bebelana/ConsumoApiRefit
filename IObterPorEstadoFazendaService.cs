using Refit;
using System.Threading.Tasks;

namespace Api
{
    public interface IObterPorEstadoFazendaService
    {
        [Get("/ObterPorEstadoFazenda/2")]
        Task<ApiResponse> getObterPorEstadoFazenda();
    }
}
