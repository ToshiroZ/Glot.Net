namespace Glot.Models
{
    using System;
    
    using Newtonsoft.Json;

    public class Languages
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }
    }
}