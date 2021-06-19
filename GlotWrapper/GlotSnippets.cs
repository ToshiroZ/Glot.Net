using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Glot.Models;
using Newtonsoft.Json;

namespace Glot
{
    /// <summary>
    /// 
    /// </summary>
    public class GlotSnippets
    {
        private readonly GlotClient _client;

        /// <summary>
        /// The constructor for creating a GlotSnippet
        /// </summary>
        /// <param name="apiKey"></param>
        public GlotSnippets(string apiKey = null)
        {
            _client = new GlotClient(apiKey);
        }
/// <summary>
/// Gets a post by id
/// </summary>
/// <param name="id">The id of the post you want to get info on</param>
/// <returns></returns>
        public async Task<GlotPost> GetPostAsync(string id)
        {
            var post = await _client.GetAsync<GlotPost>($"https://glot.io/api/snippets/{id}");
            return post;
        }
/// <summary>
/// Allows you to create a post
/// </summary>
/// <param name="post">The post that should be created on glot.io</param>
/// <returns></returns>
/// <exception cref="ArgumentNullException"></exception>
        public async Task<GlotPost> CreatePostAsync(BasePost post)
        {
            if (post is null)
                throw new ArgumentNullException($"{nameof(post)} can not be null");

            var createdPost = await _client.PostAsync<GlotPost>($"https://glot.io/api/snippets", post);
            return createdPost;
        }
/// <summary>
/// Allows you to modify a post that you own
/// </summary>
/// <param name="id">The id of the post you want to edit</param>
/// <param name="post">The new post object that should be on glot.io</param>
/// <returns>The modified post</returns>
/// <exception cref="ArgumentNullException"></exception>
        public async Task<GlotPost> ModifyPostAsync(string id, BasePost post)
        {
            if (post is null)
                throw new ArgumentNullException($"{nameof(post)} can not be null");

            var modifiedPost = await _client.PutAsync<GlotPost>($"https://glot.io/api/snippets/{id}",
                post);
            return modifiedPost;
        }
/// <summary>
/// Deletes a post from your account
/// </summary>
/// <param name="id">The id of the post you want to delete</param>
        public async Task DeletePostAsync(string id)
        { 
            await _client.DeleteAsync($"https://glot.io/api/snippets/{id}");
        }
    }
}