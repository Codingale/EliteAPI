using System;
using EliteAPI.Event.Models;
using EliteAPI.Event.Models.Abstractions;
using Newtonsoft.Json;

namespace EliteAPI.Event.Models
{
    public partial class ScannedEvent : EventBase
    {
        internal ScannedEvent()
        {
        }

        [JsonProperty("ScanType")] public string ScanType { get; private set; }
    }

    public partial class ScannedEvent
    {
        public static ScannedEvent FromJson(string json)
        {
            return JsonConvert.DeserializeObject<ScannedEvent>(json);
        }
    }
}

namespace EliteAPI.Event.Handler
{
    public partial class EventHandler
    {
        public event EventHandler<ScannedEvent> ScannedEvent;

        internal void InvokeScannedEvent(ScannedEvent arg)
        {
            ScannedEvent?.Invoke(this, arg);
        }
    }
}