using Refit;
using System.Threading.Tasks;

namespace BuscaCEPapi.Entities
{
    public interface ICepApiService
    {
        [Get("/ws/{cep}/json")]
        Task<CepResponse> GetAddressAsync(string cep);
    }
}
