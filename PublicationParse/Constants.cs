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
            {"username", "buyukveri.api"},
            {"password", "BkML5yzfGQ"}
        };

        public static string AkademikKadro = "AKADEMİK";
    }
}
