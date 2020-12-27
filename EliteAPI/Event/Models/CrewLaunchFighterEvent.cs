using System;
using EliteAPI.Event.Models;
using EliteAPI.Event.Models.Abstractions;
using Newtonsoft.Json;

namespace EliteAPI.Event.Models
{
    public partial class CrewLaunchFighterEvent : EventBase
    {
        internal CrewLaunchFighterEvent()
        {
        }

        [JsonProperty("Crew")] public string Crew { get; private set; }
    }

    public partial class CrewLaunchFighterEvent
    {
        public static CrewLaunchFighterEvent FromJson(string json)
        {
            return JsonConvert.DeserializeObject<CrewLaunchFighterEvent>(json);
        }
    }
}

namespace EliteAPI.Event.Handler
{
    public partial class EventHandler
    {
        public event EventHandler<CrewLaunchFighterEvent> CrewLaunchFighterEvent;

        internal void InvokeCrewLaunchFighterEvent(CrewLaunchFighterEvent arg)
        {
            CrewLaunchFighterEvent?.Invoke(this, arg);
        }
    }
}