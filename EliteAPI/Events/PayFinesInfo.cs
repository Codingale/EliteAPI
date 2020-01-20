using System;

namespace EliteAPI.Events
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class PayFinesInfo : EventBase
    {
        internal static PayFinesInfo Process(string json, EliteDangerousAPI api) => api.Events.InvokePayFinesEvent(JsonConvert.DeserializeObject<PayFinesInfo>(json, JsonSettings.Settings));

        [JsonProperty("Amount")]
        public long Amount { get; internal set; }
        [JsonProperty("AllFines")]
        public bool AllFines { get; internal set; }
        [JsonProperty("Faction")]
        public string Faction { get; internal set; }
        [JsonProperty("ShipID")]
        public long ShipId { get; internal set; }
    }
}
