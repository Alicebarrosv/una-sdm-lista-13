using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AmericanAirlinesApi.Models
{
    public class Aeronave
    {
        public int Id{get; set;}
        public string Modelo{get; set;} = string.Empty;
        public string CodigoCauda{get; set;} = string.Empty;
        public int CapacidadePassageiro{get; set;}
        [JsonIgnore]
        public List<Voo> Voos { get; set; } = new();
        
    }
}