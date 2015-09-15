using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Performance.Models
{
    public class DeptProgress
    {
        [JsonProperty("TargetName")]
        public string TargetName { get; set; }

        [JsonProperty("FirstName")]
        public string FirstName { get; set; }

        [JsonProperty("SecondCode")]
        public string SecondCode { get; set; }

        [JsonProperty("SecondName")]
        public string SecondName { get; set; }

        [JsonProperty("NodeName")]
        public string NodeName { get; set; }

        [JsonProperty("ReceiveDepartName")]
        public string ReceiveDepartName { get; set; }

        [JsonProperty("assignerName")]
        public string assignerName { get; set; }

        [JsonProperty("NowProgress")]
        public int NowProgress { get; set; }

        [JsonProperty("Janurary")]
        public float Janurary { get; set; }

        [JsonProperty("February")]
        public float February { get; set; }

        [JsonProperty("March")]
        public float March { get; set; }

        [JsonProperty("April")]
        public float April { get; set; }

        [JsonProperty("May")]
        public float May { get; set; }

        [JsonProperty("June")]
        public float June { get; set; }

        [JsonProperty("July")]
        public float July { get; set; }

        [JsonProperty("August")]
        public float August { get; set; }

        [JsonProperty("September")]
        public float Setember { get; set; }

        [JsonProperty("October")]
        public float October { get; set; }

        [JsonProperty("November")]
        public float November { get; set; }

        [JsonProperty("December")]
        public float December { get; set; }

    }
    [JsonObject(MemberSerialization.OptIn)]
    public class DeptPes
    {
        [JsonProperty("DeptProgressList")]
        public List<DeptProgress> DeptProgressList { get; set; }
    }
}
