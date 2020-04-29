
using Newtonsoft.Json;
using SPBDnevnik.Properties;
using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPBDnevnik.Workers
{
    class Login
    {
        public string type { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public override string ToString()
        {
            return $"{login}:{password}:{type}";
        }
    }

    public class WebWorker
    {
        public static CookieContainer cc = new CookieContainer();
        public static HttpClientHandler handler = new HttpClientHandler();
        public static HttpClient client = new HttpClient(handler);
        private static string authURL = "https://dnevnik2.petersburgedu.ru/api/user/auth/login";

        public static async Task<bool> Connect()
        {
            var authData = new Login();
            authData.login = Settings.Default.login;
            authData.password = Settings.Default.password;
            authData.type = "email";

            var json = JsonConvert.SerializeObject(authData);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            try
            {
                var response = await client.PostAsync(authURL, data);
                cc.Add(handler.CookieContainer.GetCookies(new Uri(authURL)));
                response.EnsureSuccessStatusCode();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
                throw;
            }

        }

        public static async Task<string> GetJson(string url)
        {
            try
            {
                var response = client.GetAsync(url);
                //response.EnsureSuccessStatusCode();
                string result = await response.Result.Content.ReadAsStringAsync();
                return result;
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }

        }

        public static async void GetAttach(string fileName, string fileUUID)
        {
            var response = await client.GetAsync($"https://dnevnik2.petersburgedu.ru/api/filekit/file/download?p_uuid={fileUUID}");
            response.EnsureSuccessStatusCode();
            var httpStream = await response.Content.ReadAsStreamAsync();
            using (var fileStream = File.Create(Settings.Default.saveFolder + "\\" + fileName))
            using (var reader = new StreamReader(httpStream))
            {
                httpStream.CopyTo(fileStream);
                fileStream.Flush();
            }
        }

    }
}
