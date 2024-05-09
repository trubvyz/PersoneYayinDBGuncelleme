using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicationParse
{
    public static class Constants
    {
        public static Dictionary<string, string> informationDict = new()
        {
            {"HavuzdanAktifYazarAra", "https://ubys.trabzon.edu.tr/ABPDS/AcademicInformation/BilgiGoruntulemeV2/HavuzdanAktifYazarAra"},
            {"GetAcademicCVbyAuthor", "https://ubys.trabzon.edu.tr/ABPDS/AcademicInformation/BilgiGoruntulemeV2/GetAcademicCVbyAuthor"},
            {"UBYSService", "https://ubys.trabzon.edu.tr/Framework/Integration/ServiceCaller/Report" }
        };

        public static Dictionary<string, string> UBYSServiceInformation = new()
        {
            {"username", "raporlama.api"},
            {"password", "5tNh7A*y"}
        };

        public static string AkademikKadro = "AKADEMİK";
    }
}
