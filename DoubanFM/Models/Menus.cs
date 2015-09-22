using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Performance.Models
{

    public class Menu
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("m_code")]
        public string MCode { get; set; }

        [JsonProperty("m_name")]
        public string MName { get; set; }

        [JsonProperty("image")]
        public byte[] image { get; set; }

        [JsonProperty("ssxt")]
        public string Ssxt { get; set; }

        [JsonProperty("M_JC")]
        public string Mjc { get; set; }

        [JsonProperty("M_SJCD")]
        public string Msjcd { get; set; }
    }


    public class Menus
    {
        [JsonProperty("Menus")]
        public List<Menu> Menulist { get; set; }
    }
}
