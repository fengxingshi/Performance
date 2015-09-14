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
        public int Janurary { get; set; }

        [JsonProperty("February")]
        public int February { get; set; }

        [JsonProperty("March")]
        public int March { get; set; }

        [JsonProperty("April")]
        public int April { get; set; }

        [JsonProperty("May")]
        public int May { get; set; }

        [JsonProperty("June")]
        public int June { get; set; }

        [JsonProperty("July")]
        public int July { get; set; }

        [JsonProperty("August")]
        public int August { get; set; }

        [JsonProperty("September")]
        public int Setember { get; set; }

        [JsonProperty("October")]
        public int October { get; set; }

        [JsonProperty("November")]
        public int November { get; set; }

        [JsonProperty("December")]
        public int December { get; set; }

    }
    [JsonObject(MemberSerialization.OptIn)]
    public class DeptPes
    {
        [JsonProperty("DeptProgressList")]
        public List<DeptProgress> DeptProgressList { get; set; }
    }
}
