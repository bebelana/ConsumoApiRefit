using Refit;
using System;
using System.Threading.Tasks;

namespace Api
{
    class Program
    {
        static async Task Main()
        {
            var api = RestService.For<IObterPorEstadoFazendaService>("http://tst.sportibrasil.com.br/Services/CategoriaOficialService.svc");
            
            

            var result = await  api.getObterPorEstadoFazenda();
            var lista = result.ObterPorEstadoFazendaResult;
            foreach (var item in lista)
            {
                Console.Write(item+"\n");
            }
            
            
            
           

        }
    }
}
