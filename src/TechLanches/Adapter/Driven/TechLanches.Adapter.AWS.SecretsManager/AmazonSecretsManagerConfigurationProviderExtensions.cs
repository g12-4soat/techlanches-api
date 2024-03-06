using Microsoft.Extensions.Configuration;

namespace TechLanches.Adapter.AWS.SecretsManager
{
    public static class AmazonSecretsManagerConfigurationProviderExtensions
    {
        public static void AddAmazonSecretsManager(this IConfigurationBuilder configurationBuilder,
                        string region,
                        string secretName)
        {
            var configurationSource =
                    new AmazonSecretsManagerConfigurationSource(region, secretName);

            configurationBuilder.Add(configurationSource);
        }
    }
}
