using System.IO;
using Microsoft.Extensions.Configuration;

namespace NMockaroo.Tests
{
    public abstract class ConfiguredFixture
    {
        protected IConfiguration Configuration { get; }
        protected string ApiKey { get; }

        protected ConfiguredFixture()
        {
            Configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("testsettings.json", optional: false)
                .Build();

            ApiKey = Configuration["ApiKey"];
        }
    }
}