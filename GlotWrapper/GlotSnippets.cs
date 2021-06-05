using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Glot.Models;
using Newtonsoft.Json;

namespace Glot
{
    public class GlotSnippets
    {
        private readonly GlotClient _client;

        public GlotSnippets(string apiKey = null)
        {
            _client = new GlotClient(apiKey);
        }

        public async Task<GlotPost> GetPostAsync(string id)
        {
            var post = await _client.GetAsync<GlotPost>($"https://glot.io/api/snippets/{id}");
            return post;
        }

        public async Task<GlotPost> CreatePostAsync(BasePost post)
        {
            if (post is null)
                throw new ArgumentNullException($"{nameof(post)} can not be null");

            var createdPost = await _client.PostAsync<GlotPost>($"https://glot.io/api/snippets",
                new StringContent(JsonConvert.SerializeObject(post)));
            return createdPost;
        }
        public async Task<GlotPost> ModifyPostAsync(string id, BasePost post)
        {
            if (post is null)
                throw new ArgumentNullException($"{nameof(post)} can not be null");

            var modifiedPost = await _client.PutAsync<GlotPost>($"https://glot.io/api/snippets/{id}",
                post);
            return modifiedPost;
        }
        public async Task DeletePostAsync(string id)
        { 
            await _client.DeleteAsync($"https://glot.io/api/snippets/{id}");
        }
    }
}