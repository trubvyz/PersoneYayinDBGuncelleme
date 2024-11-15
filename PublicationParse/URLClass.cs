using Newtonsoft.Json;
using System.Net;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Runtime.Caching;
using System.Text;

namespace PublicationParse
{
    public static class URLClass
    {
        #region GetWorkers
        public static async Task<dynamic?> GetWorkersFromUBYS()
        {
            string baseAddress = Constants.informationDict["UBYSService"];

            string birimKullaniciAdi = Constants.UBYSServiceInformation["username"];
            string birimKullaniciSifre = Constants.UBYSServiceInformation["password"];

            string encoded = Convert.ToBase64String(Encoding.UTF8.GetBytes($"{birimKullaniciAdi}:{birimKullaniciSifre}"));

            using HttpClient client = new();

            string data = @"{""serviceName"":""GetWorkers"",""serviceCriteria"":{ ""GetPersonEncryptedId"": true }}";

            StringContent content = new(data, Encoding.UTF8, "application/json");

            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", encoded);

            try
            {
                HttpResponseMessage response = await client.PostAsync(baseAddress, content);

                return response.IsSuccessStatusCode ? await response.Content.ReadAsStringAsync() : null as dynamic;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static async Task<List<User>?> GetWorkersFromUBYSCache()
        {
            MemoryCache cache = MemoryCache.Default;
            if (cache["Workers"] is List<User> workers)
            {
                // Önbellekte veriler varsa, doğrudan önbellekten dön
                return workers;
            }

            else
            {
                dynamic? allWorkers = await GetWorkersFromUBYS();

                if (allWorkers is null or ((dynamic)"\"Access is denied.\""))
                {
                    return null;
                }

                List<User> workersList = JsonConvert.DeserializeObject<List<User>>(allWorkers);
                // Verileri MemoryCache'e ekle
                _ = cache.Add("Workers", workersList, DateTime.Now.AddDays(30));

                return workersList;
            }
        }
        #endregion

        public static async Task<string?> GetAcademicCVbyAuthor(string personId)
        {
            string baseAddress = Constants.informationDict["GetAcademicCVbyAuthor"];

            using HttpClient client = new();

            string authorId = "!xBBx!qzOzv8aBh2KmxUxrWj7ig!xGGx!!xGGx!";

            var data = new
            {
                authorId,
                personId
            };

            try
            {
                HttpResponseMessage response = await client.PostAsJsonAsync(baseAddress, data);

                if (response.IsSuccessStatusCode)
                {
                    string res = await response.Content.ReadAsStringAsync();

                    string resNew = WebUtility.HtmlDecode(res);

                    return resNew;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}

