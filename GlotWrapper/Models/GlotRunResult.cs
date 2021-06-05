namespace Glot.Models
{
    using Newtonsoft.Json;

    public class RunResult
    {
        [JsonProperty("stdout")]
        public string Stdout { get; set; }

        [JsonProperty("stderr")]
        public string Stderr { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }
    }
}