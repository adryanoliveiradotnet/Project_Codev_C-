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
        public static async Task<bool>DBAsync()
        {
            try
            {
                var resp = await Http.GetAsync("api/db");
                return resp.IsSuccessStatusCode;
            }
            catch
            {
                return false;
            }
        }
        public class LoginResponse
        {
            public int UserId {get;set;}
            public string Username {get;set;} = "";
        }
        public static async Task<LoginResponse?>LoginAsync(string username, string password)
        {
            var resp = await Http.PostAsJsonAsync("api/auth/login", new {username, password});
            if (!resp.IsSuccessStatusCode)
                return null;
            return await resp.Content.ReadFromJsonAsync<LoginResponse>();
        }
        public class Clientes
        {
            public int Id { get; set; }
            public string Cliente { get; set; } = "";
            public string Endereço { get; set; } = "";
            public int Numero { get; set; }
            public string Bairro { get; set; } = "";

        }
        public static async Task<List<Clientes>?>ListarClientesAsync()
        {
            return await Http.GetFromJsonAsync<List<Clientes>>("api/client");
        }
        public static async Task<bool>CriarClientesAsync(Clientes clientes)
        {
            var resp = await Http.PostAsJsonAsync("api/client", clientes);
            return resp.IsSuccessStatusCode;
        }
    }
}
