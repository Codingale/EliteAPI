using System;
using EliteAPI.Event.Models;
using EliteAPI.Event.Models.Abstractions;
using Newtonsoft.Json;

namespace EliteAPI.Event.Models
{
    public partial class MaterialDiscardedEvent : EventBase
    {
        internal MaterialDiscardedEvent()
        {
        }

        [JsonProperty("Category")] public string Category { get; private set; }

        [JsonProperty("Name")] public string Name { get; private set; }

        [JsonProperty("Count")] public long Count { get; private set; }
    }

    public partial class MaterialDiscardedEvent
    {
        public static MaterialDiscardedEvent FromJson(string json)
        {
            return JsonConvert.DeserializeObject<MaterialDiscardedEvent>(json);
        }
    }
}

namespace EliteAPI.Event.Handler
{
    public partial class EventHandler
    {
        public event EventHandler<MaterialDiscardedEvent> MaterialDiscardedEvent;

        internal void InvokeMaterialDiscardedEvent(MaterialDiscardedEvent arg)
        {
            MaterialDiscardedEvent?.Invoke(this, arg);
        }
    }
}