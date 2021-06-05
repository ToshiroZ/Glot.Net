namespace Glot.Models
{
    using System.Collections.Generic;
    
    using Newtonsoft.Json;

    public class BasePost
    {
        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("public")]
        public bool Public { get; set; }

        [JsonProperty("files")]
        public List<File> Files { get; set; }
    }

    public  class File
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }
    }
}