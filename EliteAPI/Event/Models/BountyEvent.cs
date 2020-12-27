using System;
using System.Collections.Generic;
using EliteAPI.Event.Models;
using EliteAPI.Event.Models.Abstractions;
using Newtonsoft.Json;

namespace EliteAPI.Event.Models
{
    public partial class BountyEvent : EventBase
    {
        internal BountyEvent()
        {
        }

        [JsonProperty("Rewards")] public IReadOnlyList<Reward> Rewards { get; private set; }

        [JsonProperty("Target")] public string Target { get; private set; }

        [JsonProperty("Target_Localised")] public string TargetLocalised { get; private set; }

        [JsonProperty("TotalReward")] public long TotalReward { get; private set; }

        [JsonProperty("VictimFaction")] public string VictimFaction { get; private set; }

        [JsonProperty("SharedWithOthers")] public long SharedWithOthers { get; private set; }
    }

    public class Reward
    {
        internal Reward()
        {
        }

        [JsonProperty("Faction")] public string Faction { get; private set; }

        [JsonProperty("Reward")] public long RewardReward { get; private set; }
    }

    public partial class BountyEvent
    {
        public static BountyEvent FromJson(string json)
        {
            return JsonConvert.DeserializeObject<BountyEvent>(json);
        }
    }
}

namespace EliteAPI.Event.Handler
{
    public partial class EventHandler
    {
        public event EventHandler<BountyEvent> BountyEvent;

        internal void InvokeBountyEvent(BountyEvent arg)
        {
            BountyEvent?.Invoke(this, arg);
        }
    }
}