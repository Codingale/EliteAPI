using System;

namespace EliteAPI.Events
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class DockingGrantedInfo : EventBase
    {
        internal static DockingGrantedInfo Process(string json, EliteDangerousAPI api) => api.Events.InvokeDockingGrantedEvent(JsonConvert.DeserializeObject<DockingGrantedInfo>(json, JsonSettings.Settings));

        [JsonProperty("LandingPad")]
        public long LandingPad { get; internal set; }
        [JsonProperty("MarketID")]
        public long MarketId { get; internal set; }
        [JsonProperty("StationName")]
        public string StationName { get; internal set; }
        [JsonProperty("StationType")]
        public string StationType { get; internal set; }
    }
}
