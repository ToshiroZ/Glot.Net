namespace Glot.Models
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class RunCode
    {
        [JsonProperty("stdin")]
        public string Stdin { get; set; }

        [JsonProperty("files")]
        public List<File> Files { get; set; }
    }
}