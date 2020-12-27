using System;
using EliteAPI.Event.Models;
using EliteAPI.Event.Models.Abstractions;
using Newtonsoft.Json;

namespace EliteAPI.Event.Models
{
    public partial class BuyExplorationDataEvent : EventBase
    {
        internal BuyExplorationDataEvent()
        {
        }

        [JsonProperty("System")] public string System { get; private set; }

        [JsonProperty("Cost")] public long Cost { get; private set; }
    }

    public partial class BuyExplorationDataEvent
    {
        public static BuyExplorationDataEvent FromJson(string json)
        {
            return JsonConvert.DeserializeObject<BuyExplorationDataEvent>(json);
        }
    }
}

namespace EliteAPI.Event.Handler
{
    public partial class EventHandler
    {
        public event EventHandler<BuyExplorationDataEvent> BuyExplorationDataEvent;

        internal void InvokeBuyExplorationDataEvent(BuyExplorationDataEvent arg)
        {
            BuyExplorationDataEvent?.Invoke(this, arg);
        }
    }
}