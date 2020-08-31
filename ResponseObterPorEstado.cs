using Newtonsoft.Json;
namespace Api{

public class ResponseObterPorEstado {
  public string ID { get; set; }
        [JsonProperty("Nome")]
        public string Nome { get; set; }
        [JsonProperty("Sexo")]
        public string Sexo { get; set; }
        [JsonProperty("ValorMaximo")]
        public string ValorMaximo { get; set; }
        [JsonProperty("ValorMinimo")]
        public string ValorMinimo { get; set; }
        [JsonProperty("UF")]
        public string UF { get; set; }

        public override string ToString()
        { 
          return "{\n ID:"+ ID + "\n " +"Nome:"+ Nome+ "\n " + "Sexo:"+Sexo+ "\n " + "ValorMaximo:"+ValorMaximo+ "\n " +"ValorMinimo:"+ValorMinimo+ "\n " +"UF:"+ UF +" \n },"; }
}

}
