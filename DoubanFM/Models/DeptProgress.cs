using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Performance.Models
{
    class DeptProgress
    {
        [JsonProperty("target_name")]
        public string TargetName { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("sencond_code")]
        public string SencondCode { get; set; }

        [JsonProperty("sencond_name")]
        public string SencondName { get; set; }

        [JsonProperty("nodename")]
        public string NodeName { get; set; }

        [JsonProperty("receive_depart_name")]
        public string ReceiveDepartName { get; set; }

        [JsonProperty("assigner_name")]
        public string assignerName { get; set; }

        [JsonProperty("nowprogress")]
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
    public class DeptProgresses
    {
        [JsonProperty("DeptProgressList")]
        public List<Dept> DeptProgressList { get; set; }
    }
}
