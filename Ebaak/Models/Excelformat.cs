using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ebaak.Models
{
    public class Excelformat
    {
        [JsonProperty("F1")]
        public string PlateNo { get; set; }
        [JsonProperty("F2")]
        public string CityNo { get; set; }
        [JsonProperty("F3")]
        public string MotorKind { get; set; }
        [JsonProperty("F4")]
        public string Color { get; set; }
        [JsonProperty("F5")]
        public string EngineNo { get; set; }
        [JsonProperty("F6")]
        public string BodyNo { get; set; }
        [JsonProperty("F7")]
        public string BuildYear { get; set; }
        [JsonProperty("F8")]
        public string System { get; set; }
        [JsonProperty("F9")]
        public string Type { get; set; }
        [JsonProperty("F10")]
        public string Code { get; set; }
        [JsonProperty("F11")]
        public string DocumentNo { get; set; }
    }

    
}