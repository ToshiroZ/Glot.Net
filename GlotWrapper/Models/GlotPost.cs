namespace Glot.Models
{
    using System;
    
    using Newtonsoft.Json;
/// <summary>
/// 
/// </summary>
    public class GlotPost : BasePost
{
    /// <summary>
    /// 
    /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }
/// <summary>
/// 
/// </summary>
        [JsonProperty("url")]
        public Uri Url { get; set; }
/// <summary>
/// 
/// </summary>
        [JsonProperty("created")]
        public DateTimeOffset Created { get; set; }
/// <summary>
/// 
/// </summary>
        [JsonProperty("modified")]
        public DateTimeOffset Modified { get; set; }
/// <summary>
/// 
/// </summary>
        [JsonProperty("files_hash")]
        public string FilesHash { get; set; }
/// <summary>
/// 
/// </summary>
        [JsonProperty("owner")]
        public string Owner { get; set; }
    }
}