using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

public class ApiService
{
    private readonly HttpClient _httpClient;
    private readonly ILogger<ApiService> _logger;

    public ApiService(HttpClient httpClient, ILogger<ApiService> logger)
    {
        _httpClient = httpClient;
        _logger = logger;
    }

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

public class Post
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Body { get; set; }
    public int UserId { get; set; }
}
