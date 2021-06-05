namespace Glot.Models
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
/// <summary>
/// 
/// </summary>
    public class RunCode
    {/// <summary>
     /// Passed stuff in to the input of the application
     /// </summary>
        [JsonProperty("stdin")]
        public string Stdin { get; set; }
/// <summary>
/// The files containing the code to run on glot.io
/// </summary>
        [JsonProperty("files")]
        public List<File> Files { get; set; }
    }
}