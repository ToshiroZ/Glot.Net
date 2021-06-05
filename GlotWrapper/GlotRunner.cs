using System.Collections.Generic;
using System.Threading.Tasks;
using Glot.Models;

namespace Glot
{
    /// <summary>
    /// 
    /// </summary>
    public class GlotRunner
    {
        private readonly GlotClient _client;

        /// <summary>
        /// The constructor to get a glotrunner
        /// </summary>
        /// <param name="apiKey">This is required if you want to run code on glot.io</param>
        public GlotRunner(string apiKey = null)
        {
            _client = new GlotClient(apiKey);
        }

        /// <summary>
        /// Gets languages you can use on glot.io
        /// </summary>
        /// <returns></returns>
        public async Task<ICollection<Languages>> GetLanguagesAsync()
        {
            return await _client.GetAsync<List<Languages>>("https://glot.io/api/run");
        }

        /// <summary>
        /// Gets language versions you can use to run code
        /// </summary>
        /// <param name="language">The language you want to check versions for <see cref="GetLanguagesAsync"/>> for the list of languages</param>
        /// <returns></returns>
        public async Task<ICollection<LanguageVersions>> GetLanguageVerionsAsync(string language)
        {
            return await _client.GetAsync<List<LanguageVersions>>($"https://glot.io/api/run/languages/{language}");
        }

        /// <summary>
        ///  Runs code on glot.io requires a token
        /// </summary>
        /// <param name="language">This is the language the code is written in</param>
        /// <param name="code">This is the code you want to run on glot.io</param>
        /// <remarks>This requires a valid api key to be set on glot.io</remarks>
        /// <returns></returns>
        public async Task<RunResult> RunCodeAsync(string language, RunCode code)
        {
            return await _client.PostAsync<RunResult>($"https://glot.io/api/run/{language}/latest", code);
        }
    }
}