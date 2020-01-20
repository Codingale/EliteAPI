using System;

namespace EliteAPI.Events
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class CommitCrimeInfo : EventBase
    {
        internal static CommitCrimeInfo Process(string json, EliteDangerousAPI api) => api.Events.InvokeCommitCrimeEvent(JsonConvert.DeserializeObject<CommitCrimeInfo>(json, JsonSettings.Settings));

        [JsonProperty("CrimeType")]
        public string CrimeType { get; internal set; }
        [JsonProperty("Faction")]
        public string Faction { get; internal set; }
        [JsonProperty("Victim")]
        public string Victim { get; internal set; }
        [JsonProperty("Victim_Localised")]
        public string VictimLocalised { get; internal set; }
        [JsonProperty("Bounty")]
        public long Bounty { get; internal set; }
    }
}
