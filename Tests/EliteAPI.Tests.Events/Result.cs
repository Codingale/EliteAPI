﻿using Newtonsoft.Json;

namespace EliteAPI.Tests.Events
{
    public class Result
    {
        [JsonProperty("title")] public string Title { get; set; }

        [JsonProperty("message")] public string Message { get; set; }

        [JsonProperty("file")] public string Path { get; set; }

        [JsonProperty("line")] public int Line { get; set; }

        [JsonProperty("annotation_level")] public string Level { get; set; } = "notice";
    }
}