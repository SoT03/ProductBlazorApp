using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using ProductBlazorApp.Models;






public class PostService
{
    private readonly HttpClient _httpClient;
    private readonly ILogger<PostService> _logger;

    public PostService(HttpClient httpClient, ILogger<PostService> logger)
    {
        _httpClient = httpClient;
        _logger = logger;
    }


    //Get method
    public async Task GetPost()
    {
        var url = "https://jsonplaceholder.typicode.com/posts/1";
        try
        {
            var response = await _httpClient.GetFromJsonAsync<Post>(url);
            if (response != null)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($" GET SUCCESS: title: {response.Title}");
                Console.WriteLine($" Id: {response.Id}");
                Console.WriteLine($" Body: {response.Body}");
                Console.WriteLine($" User id: {response.UserId}");
                
               
            }
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"GET_ERROR: {ex.Message}");
            
        }
    }


    //Post method
    public async Task CreatePost()
    {
        var url = "https://jsonplaceholder.typicode.com/posts";
        var newPost = new Post { Title = "New Post", Body = "Body", UserId = 1 };

        try
        {
            var response = await _httpClient.PostAsJsonAsync(url, newPost);
            var createdPost = await response.Content.ReadFromJsonAsync<Post>();

            if (createdPost != null)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"POST SUCCESS: Id = {createdPost.Id}, Title = {createdPost.Title}, Body = {createdPost.Body}, UserId = {createdPost.UserId}");

            }
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"POST_ERROR: {ex.Message}");
           
        }
    }

}

