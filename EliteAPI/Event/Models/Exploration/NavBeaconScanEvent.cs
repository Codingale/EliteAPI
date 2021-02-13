using System;

using EliteAPI.Event.Models;
using EliteAPI.Event.Models.Abstractions;

using Newtonsoft.Json;

using ProtoBuf;

namespace EliteAPI.Event.Models
{

    [ProtoContract(ImplicitFields = ImplicitFields.AllPublic)]
    [ProtoInclude(500, typeof(EventBase))]
    public partial class NavBeaconScanEvent : EventBase
    {
        internal NavBeaconScanEvent() { }

        [JsonProperty("NumBodies")]
        public long NumBodies { get; private set; }
    }

    public partial class NavBeaconScanEvent
    {
        public static NavBeaconScanEvent FromJson(string json)
        {
            return JsonConvert.DeserializeObject<NavBeaconScanEvent>(json);
        }
    }
}

namespace EliteAPI.Event.Handler
{
    public partial class EventHandler
    {
        public event EventHandler<NavBeaconScanEvent> NavBeaconScanEvent;

        internal void InvokeNavBeaconScanEvent(NavBeaconScanEvent arg)
        {
            NavBeaconScanEvent?.Invoke(this, arg);
        }
    }
}