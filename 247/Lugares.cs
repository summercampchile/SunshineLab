using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.MobileServices;
using Newtonsoft.Json;

namespace _247
{
    public class Lugares
    {
        public string Id { get; set; }

        [JsonProperty(PropertyName = "latitud")]
        public double Latitud { get; set; }
    
        [JsonProperty(PropertyName = "longitud")]
        public double Longitud { get; set; }

        [JsonProperty(PropertyName = "nombre")]
        public string Nombre { get; set; }

        [JsonProperty(PropertyName = "telefono")]
        public string Telefono { get; set; }

        [JsonProperty(PropertyName = "direccion")]
        public string Direccion { get; set; }

        [JsonProperty(PropertyName = "sitioWeb")]
        public string SitioWeb { get; set; }

        [JsonProperty(PropertyName = "categoria")]
        public int Categoria { get; set; }

        [JsonProperty(PropertyName = "horario")]
        public string Horario { get; set; }

        [JsonProperty(PropertyName = "delivery")]
        public int Delivery { get; set; }

        [JsonProperty(PropertyName = "metodoPago")]
        public int MetodoPago { get; set; }
    }
}
