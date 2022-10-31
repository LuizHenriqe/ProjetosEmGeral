using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace BuscaCEPapi.Entities
{
    public class CepResponse
    {
        [JsonProperty(propertyName: "cep")]
        public string Cep { set; get; }
        
        [JsonProperty("logradouro")]
        public string Logradouro { set; get; }
        
        [JsonProperty("complemento")]
        public string Complemento { set; get; }
        
        [JsonProperty("bairro")]
        public string Bairro{ set; get; }
        
        [JsonProperty("localidade")]
        public string Localidade { set; get; }
        
        [JsonProperty("uf")]
        public string Uf { set; get; }
        
        [JsonProperty("unidade")]
        public string Unidade { set; get; }
        
        [JsonProperty("ibge")]
        public string Ibge { set; get; }
        
        [JsonProperty("gia")]
        public string Gia { set; get; }


        public override string ToString()
        {
            return $"Cep: {Cep}, Logradouro:{Logradouro}, Bairro:{Bairro}";
        }

    }


}
