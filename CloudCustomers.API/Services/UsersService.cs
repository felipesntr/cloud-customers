using CloudCustomers.API.Models;

namespace CloudCustomers.API.Services
{
    public interface IUsersService
    {
        public Task<List<User>> GetAllUsers();
    }

    public class UsersService : IUsersService
    {
        public readonly HttpClient _httpClient;
        public UsersService(HttpClient httpClient) {
            _httpClient = httpClient;
        }

        public async Task<List<User>> GetAllUsers()
        {
            var usersResponse = await _httpClient.GetAsync("https://example.com");
            var users = await usersResponse.Content.ReadFromJsonAsync<List<User>>();
            return users; 
        }
    }
}
