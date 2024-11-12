namespace PublicationParse
{
    public static class Constants
    {
        public static Dictionary<string, string> informationDict = new()
        {
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
