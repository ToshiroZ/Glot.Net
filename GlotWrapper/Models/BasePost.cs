namespace Glot.Models
{
    using System.Collections.Generic;
    
    using Newtonsoft.Json;
/// <summary>
/// 
/// </summary>
    public class BasePost
    {/// <summary>
     /// 
     /// </summary>
        [JsonProperty("language")]
        public string Language { get; set; }
/// <summary>
/// 
/// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }
/// <summary>
/// 
/// </summary>
        [JsonProperty("public")]
        public bool Public { get; set; }
/// <summary>
/// 
/// </summary>
        [JsonProperty("files")]
        public List<File> Files { get; set; }
    }
/// <summary>
/// 
/// </summary>
    public  class File
    {/// <summary>
     /// 
     /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
/// <summary>
/// 
/// </summary>
        [JsonProperty("content")]
        public string Content { get; set; }
    }
}