using PCLAppConfig;

namespace XamarinConfig
{
    public static class AppConfig
    {
        public static string config = ConfigurationManager.AppSettings["config.text"];
    }
}
