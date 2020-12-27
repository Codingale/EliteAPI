using System;
using EliteAPI.Event.Models;
using EliteAPI.Event.Models.Abstractions;
using Newtonsoft.Json;

namespace EliteAPI.Event.Models
{
    public partial class CommitCrimeEvent : EventBase
    {
        internal CommitCrimeEvent()
        {
        }

        [JsonProperty("CrimeType")] public string CrimeType { get; private set; }

        [JsonProperty("Faction")] public string Faction { get; private set; }

        [JsonProperty("Fine")] public long Fine { get; private set; }
    }

    public partial class CommitCrimeEvent
    {
        public static CommitCrimeEvent FromJson(string json)
        {
            return JsonConvert.DeserializeObject<CommitCrimeEvent>(json);
        }
    }
}

namespace EliteAPI.Event.Handler
{
    public partial class EventHandler
    {
        public event EventHandler<CommitCrimeEvent> CommitCrimeEvent;

        internal void InvokeCommitCrimeEvent(CommitCrimeEvent arg)
        {
            CommitCrimeEvent?.Invoke(this, arg);
        }
    }
}