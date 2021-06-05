namespace Glot.Models
{
    using System;
    
    using Newtonsoft.Json;

    public class LanguageVersions
    {
        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }
    }
}