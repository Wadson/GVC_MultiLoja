using System.Net;

namespace GVC.UTIL
{
    public static class InternetHelper
    {
        public static bool TemInternet()
        {
            try
            {
                using var client = new WebClient();
                using var stream = client.OpenRead("https://www.google.com");
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
