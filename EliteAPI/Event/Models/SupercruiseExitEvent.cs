using System;
using EliteAPI.Event.Models;
using EliteAPI.Event.Models.Abstractions;
using Newtonsoft.Json;

namespace EliteAPI.Event.Models
{
    public partial class SupercruiseExitEvent : EventBase
    {
        internal SupercruiseExitEvent()
        {
        }

        [JsonProperty("StarSystem")] public string StarSystem { get; private set; }

        [JsonProperty("SystemAddress")] public long SystemAddress { get; private set; }

        [JsonProperty("Body")] public string Body { get; private set; }

        [JsonProperty("BodyID")] public long BodyId { get; private set; }

        [JsonProperty("BodyType")] public string BodyType { get; private set; }
    }

    public partial class SupercruiseExitEvent
    {
        public static SupercruiseExitEvent FromJson(string json)
        {
            return JsonConvert.DeserializeObject<SupercruiseExitEvent>(json);
        }
    }
}

namespace EliteAPI.Event.Handler
{
    public partial class EventHandler
    {
        public event EventHandler<SupercruiseExitEvent> SupercruiseExitEvent;

        internal void InvokeSupercruiseExitEvent(SupercruiseExitEvent arg)
        {
            SupercruiseExitEvent?.Invoke(this, arg);
        }
    }
}