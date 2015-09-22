using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media.Imaging;

namespace Performance.Models
{

    public class Menu
    {
        [JsonProperty("ID")]
        public int Id { get; set; }

        [JsonProperty("MCODE")]
        public string MCode { get; set; }

        [JsonProperty("MNAME")]
        public string MName { get; set; }

        [JsonProperty("IMAGE")]
        public byte[] Image { get; set; }

        [JsonProperty("ICONIMAGE")]
        public string IconImage { get; set; }

        [JsonProperty("SSXT")]
        public string Ssxt { get; set; }

        [JsonProperty("MJC")]
        public string Mjc { get; set; }

        [JsonProperty("MSJCD")]
        public string Msjcd { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public class Menus
    {
        [JsonProperty("MenuList")]
        public List<Menu> Menulist { get; set; }

    }
}
