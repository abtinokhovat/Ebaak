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
        [JsonProperty("F12")]
        public string CardexCode { get; set; }
        [JsonProperty("F13")]
        public string EconomicCode { get; set; }
        [JsonProperty("F14")]
        public string Police { get; set; }
        [JsonProperty("F15")]
        public string Name { get; set; }
        [JsonProperty("F16")]
        public string Post { get; set; }
        [JsonProperty("F17")]
        public string Wheels { get; set; }
        [JsonProperty("F18")]
        public string Axis { get; set; }
        [JsonProperty("F19")]
        public string Capacity { get; set; }
        [JsonProperty("F20")]
        public string Cylender { get; set; }
        [JsonProperty("F21")]
        public string Fuel { get; set; }
        [JsonProperty("F22")]
        public string Volume { get; set; }
        [JsonProperty("F23")]
        public string SellerName { get; set; }
        [JsonProperty("F24")]
        public string NationalId { get; set; }
        [JsonProperty("F25")]
        public string Address { get; set; }
        [JsonProperty("F26")]
        public string Mobile { get; set; }
        [JsonProperty("F27")]
        public string Telephone { get; set; }
    }

    
}