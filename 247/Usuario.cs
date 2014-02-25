using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.MobileServices;
using Newtonsoft.Json;

namespace _247
{
    class Users
    {
        public string Id { get; set; }

        [JsonProperty(PropertyName = "nombre")]
        public string nombre { get; set; }

        [JsonProperty(PropertyName = "apellido")]
        public string apellido { get; set; }

        [JsonProperty(PropertyName = "ciudad")]
        public string ciudad { get; set; }

        [JsonProperty(PropertyName = "region")]
        public string region { get; set; }

        [JsonProperty(PropertyName = "mail")]
        public string mail { get; set; }

        [JsonProperty(PropertyName = "password")]
        public string password { get; set; }

    }
}
