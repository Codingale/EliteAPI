using System;

namespace EliteAPI.Events
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class ShipTargetedInfo : EventBase
    {
        internal static ShipTargetedInfo Process(string json, EliteDangerousAPI api) => api.Events.InvokeShipTargetedEvent(JsonConvert.DeserializeObject<ShipTargetedInfo>(json, JsonSettings.Settings));

        [JsonProperty("TargetLocked")]
        public bool TargetLocked { get; internal set; }
        [JsonProperty("Ship")]
        public string Ship { get; internal set; }
        [JsonProperty("Ship_Localised")]
        public string ShipLocalised { get; internal set; }
        [JsonProperty("ScanStage")]
        public long ScanStage { get; internal set; }
        [JsonProperty("PilotName")]
        public string PilotName { get; internal set; }
        [JsonProperty("PilotName_Localised")]
        public string PilotNameLocalised { get; internal set; }
        [JsonProperty("PilotRank")]
        public string PilotRank { get; internal set; }
        [JsonProperty("ShieldHealth")]
        public double ShieldHealth { get; internal set; }
        [JsonProperty("HullHealth")]
        public double HullHealth { get; internal set; }
        [JsonProperty("Faction")]
        public string Faction { get; internal set; }
        [JsonProperty("LegalStatus")]
        public string LegalStatus { get; internal set; }
        [JsonProperty("Bounty")]
        public long Bounty { get; internal set; }
        [JsonProperty("Subsystem")]
        public string Subsystem { get; internal set; }
        [JsonProperty("Subsystem_Localised")]
        public string SubsystemLocalised { get; internal set; }
        [JsonProperty("SubsystemHealth")]
        public double SubsystemHealth { get; internal set; }
    }
}
