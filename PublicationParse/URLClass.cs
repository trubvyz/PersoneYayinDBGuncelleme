using System.Runtime.Caching;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace PublicationParse
{
    public static class URLClass
    {
        public static async Task<List<AktifYazarModel>> GetAktifYazarModelAsync()
        {

            var baseAddress = Constants.informationDict["HavuzdanAktifYazarAra"];
            var content = new StringContent(" ");

            using HttpClient client = new();
            try
            {
                var response = await client.PostAsync(baseAddress, content);

                if (response.IsSuccessStatusCode)
                {
                    var responseContent = await response.Content.ReadAsStringAsync();
                    var sonuc = JsonConvert.DeserializeObject<List<AktifYazarModel>>(responseContent);

                    return sonuc;
                }

                return null;
            }
            catch (Exception ex)
            {
                return null;
                
            }
        }

        #region GetWorkers
        public static async Task<dynamic> GetWorkersFromUBYS()
        {
            var baseAddress = Constants.informationDict["UBYSService"];

            var birimKullaniciAdi = Constants.UBYSServiceInformation["username"];           
            var birimKullaniciSifre = Constants.UBYSServiceInformation["password"];

            string encoded = Convert.ToBase64String(Encoding.UTF8.GetBytes($"{birimKullaniciAdi}:{birimKullaniciSifre}"));

            using HttpClient client = new();

            string data = @"{""serviceName"":""GetWorkers"",""serviceCriteria"":{}}";

            StringContent content = new(data, Encoding.UTF8, "application/json");

            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", encoded);

            try
            {
                HttpResponseMessage response = await client.PostAsync(baseAddress, content);

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsStringAsync();
                }

                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                return null;
            }



        }

        public static async Task<List<User>> GetWorkersFromUBYSCache()
        {
            var cache = MemoryCache.Default;
            if (cache["Workers"] is List<User> workers)
            {
                // Önbellekte veriler varsa, doğrudan önbellekten dön
                return workers;
            }

            else
            {
                var allWorkers = await GetWorkersFromUBYS();

                List<User> workersList = JsonConvert.DeserializeObject<List<User>>(allWorkers);
                // Verileri MemoryCache'e ekle
                cache.Add("Workers", workersList, DateTime.Now.AddDays(30));

                return workersList;

            }
        }

        #endregion

        public static async Task<string> GetAcademicCVbyAuthor(int authorId, int personId)
        {
            var baseAddress = Constants.informationDict["GetAcademicCVbyAuthor"];

            using HttpClient client = new();

            string data = "{" + "authorId:" + authorId + "," + "personId:" + personId + "}";

            StringContent content = new(data, Encoding.UTF8, "application/json");

            try
            {
                var response = await client.PostAsync(baseAddress, content);

                if (response.IsSuccessStatusCode)
                {
                    var res = await response.Content.ReadAsStringAsync();

                    var resNew = WebUtility.HtmlDecode(res);

                    return resNew;
                }

                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                return null;
            }



        }

    }
}

