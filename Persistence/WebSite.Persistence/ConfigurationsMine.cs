using Microsoft.Extensions.Configuration;

namespace WebSite.Persistence
{
    static class ConfigurationsMine
    {
        public static string GetConnectionString
        {
            get
            {
                ConfigurationManager cf = new();
                cf.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/WebSite.API"));
                cf.AddJsonFile("appsettings.json");

                return cf.GetConnectionString("sql");
            }
        }
    }
}
