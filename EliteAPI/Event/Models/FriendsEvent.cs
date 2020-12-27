using System;
using EliteAPI.Event.Models;
using EliteAPI.Event.Models.Abstractions;
using Newtonsoft.Json;

namespace EliteAPI.Event.Models
{
    public partial class FriendsEvent : EventBase
    {
        internal FriendsEvent()
        {
        }

        [JsonProperty("Status")] public string Status { get; private set; }

        [JsonProperty("Name")] public string Name { get; private set; }
    }

    public partial class FriendsEvent
    {
        public static FriendsEvent FromJson(string json)
        {
            return JsonConvert.DeserializeObject<FriendsEvent>(json);
        }
    }
}

namespace EliteAPI.Event.Handler
{
    public partial class EventHandler
    {
        public event EventHandler<FriendsEvent> FriendsEvent;

        internal void InvokeFriendsEvent(FriendsEvent arg)
        {
            FriendsEvent?.Invoke(this, arg);
        }
    }
}