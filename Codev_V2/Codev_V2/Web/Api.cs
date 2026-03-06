using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Reflection.Metadata;
using System.Security.RightsManagement;
using System.Text;

namespace Codev_V2.Web
{
    public static class Api
    {
        public static HttpClient Http = new()
        {
            BaseAddress = new Uri("https://localhost:7097")
        };
        public static async Task<bool> HealthAsync()
        {
            try
            {
                var resp = await Http.GetAsync("api/health");
                return resp.IsSuccessStatusCode;
            }
            catch
            {
                return false;
            }
        }
        public static async Task<LoginResponse?>LoginAsync(string username, string password)
        {
            var resp = await Http.PostAsJsonAsync("api/auth/login", new { username, password });
            if (!resp.IsSuccessStatusCode)
                return null;
            return await resp.Content.ReadFromJsonAsync<LoginResponse>();
        }
        public class LoginResponse
        {
            public int UserId { get; set; }
            public string Username { get; set; } = "";
        }
    }
}
