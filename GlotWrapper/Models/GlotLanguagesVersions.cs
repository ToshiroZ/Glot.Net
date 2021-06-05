namespace Glot.Models
{
    using System;
    
    using Newtonsoft.Json;
/// <summary>
/// 
/// </summary>
    public class LanguageVersions
    {/// <summary>
     /// 
     /// </summary>
        [JsonProperty("url")]
        public Uri Url { get; set; }
/// <summary>
/// 
/// </summary>
        [JsonProperty("version")]
        public string Version { get; set; }
    }
}