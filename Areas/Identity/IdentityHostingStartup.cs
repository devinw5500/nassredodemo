using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(TaxSystemNASS.Areas.Identity.IdentityHostingStartup))]

namespace TaxSystemNASS.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) =>
            {
            });
        }
    }
}