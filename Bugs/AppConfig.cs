
using Microsoft.Extensions.Configuration;

namespace Bugs;

public static class AppConfig
{
    public static AppSettings Settings { get; set; } = new AppSettings();

    public static void Initialize()
    {
        IConfiguration config = new ConfigurationBuilder()
            .SetBasePath(AppContext.BaseDirectory)
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .Build();

        Settings = config.GetSection("AppSettings").Get<AppSettings>() ?? new AppSettings();
    }
}

public class AppSettings
{
    public string AppName { get; set; } = string.Empty;
    public string AppVersion { get; set; } = string.Empty;
    public string ConnectionString { get; set; } = string.Empty;
    public DropdownLists DropdownLists { get; set; } = new DropdownLists();
}

public class DropdownLists
{
    public List<string> BondTypes { get; set; } = new List<string>();
    public List<string> PropertyDescriptions { get; set; } = new List<string>();
    public List<string> ContractPrices { get; set; } = new List<string>();
    public List<string> RenewalFees { get; set; } = new List<string>();
    public List<string> TransferFees { get; set; } = new List<string>();
}