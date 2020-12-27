using System;
using EliteAPI.Event.Models;
using EliteAPI.Event.Models.Abstractions;
using Newtonsoft.Json;

namespace EliteAPI.Event.Models
{
    public partial class LaunchDroneEvent : EventBase
    {
        internal LaunchDroneEvent()
        {
        }

        [JsonProperty("Type")] public string Type { get; private set; }
    }

    public partial class LaunchDroneEvent
    {
        public static LaunchDroneEvent FromJson(string json)
        {
            return JsonConvert.DeserializeObject<LaunchDroneEvent>(json);
        }
    }
}

namespace EliteAPI.Event.Handler
{
    public partial class EventHandler
    {
        public event EventHandler<LaunchDroneEvent> LaunchDroneEvent;

        internal void InvokeLaunchDroneEvent(LaunchDroneEvent arg)
        {
            LaunchDroneEvent?.Invoke(this, arg);
        }
    }
}