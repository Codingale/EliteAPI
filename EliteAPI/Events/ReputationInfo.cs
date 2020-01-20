using System;

namespace EliteAPI.Events
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class ReputationInfo : EventBase
    {
        internal static ReputationInfo Process(string json, EliteDangerousAPI api) => api.Events.InvokeReputationEvent(JsonConvert.DeserializeObject<ReputationInfo>(json, JsonSettings.Settings));

        [JsonProperty("Empire")]
        public double Empire { get; internal set; }
        [JsonProperty("Federation")]
        public double Federation { get; internal set; }
        [JsonProperty("Independent")]
        public double Independent { get; internal set; }
        [JsonProperty("Alliance")]
        public double Alliance { get; internal set; }
    }
}
