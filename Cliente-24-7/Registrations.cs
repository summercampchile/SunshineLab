using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente_24_7
{
    class Registrations
    {
        public string Id { get; set; }

        [JsonProperty(PropertyName = "latitud")]
        public double Latitud { get; set; }

        [JsonProperty(PropertyName = "longitud")]
        public double Longitud { get; set; }

        [JsonProperty(PropertyName = "nombre")]
        public string Nombre { get; set; }

        [JsonProperty(PropertyName = "nombretienda")]
        public string NombreTienda { get; set; }

        [JsonProperty(PropertyName = "categoria")]
        public int Categoria { get; set; }

        [JsonProperty(PropertyName = "comentario")]
        public string Comentario { get; set; }
    }
}
