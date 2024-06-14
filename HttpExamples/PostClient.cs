using HttpExamples.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace HttpExamples
{
    public class PostService
    {
        private HttpClient _httpClient;

        public PostService()
        {
            _httpClient = new HttpClient();
        }
        public  async Task GetPosts()
        {
            string url = "[7:16 PM] Courses Srbija\r\nhttps://jsonplaceholder.typicode.com/posts";

           HttpResponseMessage response = await _httpClient.GetAsync(url);

            

            if(response.IsSuccessStatusCode)
            {
                string response = await response.Content.ReadAsStringAsync();
                List<Post> allPosts = JsonConvert.DeserializeObject<List<Post>>(response);
                Console.WriteLine(response);    
            }
        } 

    }
}
