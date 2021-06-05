namespace Glot.Models
{
    using System;
    
    using Newtonsoft.Json;

    public class GlotPost : BasePost
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("created")]
        public DateTimeOffset Created { get; set; }

        [JsonProperty("modified")]
        public DateTimeOffset Modified { get; set; }

        [JsonProperty("files_hash")]
        public string FilesHash { get; set; }

        [JsonProperty("owner")]
        public string Owner { get; set; }
    }
}