using HtmlAgilityPack;
using System.Net;
using System.Text;

namespace PublicationParse
{
    public static class AcademicCVParse
    {
        public static List<string> WorkingPlaces(string academicCVbyAuthorString)
        {
            // HtmlAgilityPack ile HTML dokümanı oluşturalım
            HtmlDocument doc = new();
            doc.LoadHtml(academicCVbyAuthorString);

            HtmlNode divNode = doc.DocumentNode.SelectSingleNode("//div[@class='profile-usertitle-unit']");

            List<string> results = [];

            if (divNode != null)
            {
                // Bulunan bölümü "-" karakterine göre bölelim
                List<string> parcalar = divNode.InnerText.Split('-').ToList();

                // Her bir parçayı işleyelim
                foreach (string parca in parcalar)
                {
                    // Parçanın başındaki ve sonundaki boşlukları kaldıralım
                    string temizlenmisParca = parca.Trim();

                    // HTML kodlarını uygun karakterlere dönüştürelim
                    string duzeltilmisParca = WebUtility.HtmlDecode(temizlenmisParca);

                    // Sonuçları ekrana yazdıralım
                    results.Add(duzeltilmisParca);
                }
            }

            return results;
        }

        public static string GetPublications(string academicCVbyAuthorString)
        {
            // Başlangıç ve bitiş desenleri
            string baslangicDeseni = "JSON.parse(Base64.decode(\"";
            string bitisDeseni = "\"));";

            // Verilen string içinde başlangıç ve bitiş desenlerinin konumlarını bulma
            int baslangicIndex = academicCVbyAuthorString.IndexOf(baslangicDeseni);
            int bitisIndex = academicCVbyAuthorString.IndexOf(bitisDeseni);

            // Eğer başlangıç ve bitiş desenleri varsa ve bitiş deseni başlangıç deseninden sonra geliyorsa
            if (baslangicIndex != -1 && bitisIndex != -1 && bitisIndex > baslangicIndex)
            {
                // Başlangıç ve bitiş desenlerinin arasındaki alt dizeyi al
                string aradakiString = academicCVbyAuthorString.Substring(baslangicIndex + baslangicDeseni.Length, bitisIndex - baslangicIndex - baslangicDeseni.Length);

                // Base64 kodunu çöz
                byte[] byteDizisi = Convert.FromBase64String(aradakiString);

                // Byte dizisini string'e dönüştür
                string cozulmusString = Encoding.UTF8.GetString(byteDizisi);

                //string cozulmusStringNew = WebUtility.HtmlDecode(cozulmusString);

                return cozulmusString;
            }
            else
            {
                return null;
            }
        }
    }
}
