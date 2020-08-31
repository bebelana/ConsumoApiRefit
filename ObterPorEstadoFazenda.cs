using Newtonsoft.Json;

using System.Collections.Generic; 

namespace Api
{
    public class ApiResponse
    {
        [JsonProperty("ObterPorEstadoFazendaResult")]
        public List<ResponseObterPorEstado> ObterPorEstadoFazendaResult {get;set;}
        
    }
}
