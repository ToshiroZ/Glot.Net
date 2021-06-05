namespace Glot.Models
{
    using Newtonsoft.Json;
/// <summary>
/// 
/// </summary>
    public class RunResult
    {/// <summary>
     /// 
     /// </summary>
        [JsonProperty("stdout")]
        public string Stdout { get; set; }
/// <summary>
/// 
/// </summary>
        [JsonProperty("stderr")]
        public string Stderr { get; set; }
/// <summary>
/// 
/// </summary>
        [JsonProperty("error")]
        public string Error { get; set; }
    }
}