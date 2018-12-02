
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp
{
    public static class Constants
    {
        public static string USERNAME = "username";
        public static string PASSWORD = "password";
        //public static string BASE_URL = "https://webhook.site/e16b07f8-fa6c-477d-b6a1-fbc22b9e0aa8";
        public static string BASE_URL = "https://edc15afa-0fd5-486a-b546-9fd31202613c.mock.pstmn.io";
        public static int POST_SUCCESS = 1;
        public static int POST_FAIL = 0;

        public static async Task<T> sendPostRequest<T>(string url, object sendignObject)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var content = new StringContent(JsonConvert.SerializeObject(sendignObject), Encoding.UTF8, "application/json");
                    var response = await client.PostAsync(url, content);
                    var responseString = await response.Content.ReadAsStringAsync();
                    T loginData = JsonConvert.DeserializeObject<T>(responseString);
                    return loginData;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return (T)Activator.CreateInstance(typeof(T));
            }
        }

        public static async Task<T> sendPostRequest<T>(string url)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var response = await client.PostAsync(url, null);
                    var responseString = await response.Content.ReadAsStringAsync();
                    T loginData = JsonConvert.DeserializeObject<T>(responseString);
                    return loginData;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return (T)Activator.CreateInstance(typeof(T));
            }
        }
    }
}
