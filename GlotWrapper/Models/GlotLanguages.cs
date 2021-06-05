namespace Glot.Models
{
    using System;
    
    using Newtonsoft.Json;
/// <summary>
/// 
/// </summary>
    public class Languages
    {/// <summary>
     /// 
     /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
/// <summary>
/// 
/// </summary>
        [JsonProperty("url")]
        public Uri Url { get; set; }
    }
}