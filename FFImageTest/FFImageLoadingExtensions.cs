using FFImageLoading.Config;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Maui.Hosting;
using System.Net;
using System.Net.Http;

namespace FFImageTest
{
    public class TrustSelfSignedCertificatesConfiguration : Configuration
    {
        public TrustSelfSignedCertificatesConfiguration()
        {
            HttpClient = new HttpClient(
                new HttpClientHandler() 
                { 
                    AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate,
                    ServerCertificateCustomValidationCallback = (message, cert, chain, errors) => true
                }
            );
        }
    }

    public static class FFImageLoadingExtensions
    {
        public static MauiAppBuilder UseFFImageLoadingTrustSelfSignedCertificates(this MauiAppBuilder mauiAppBuilder)
        {
            mauiAppBuilder.Services.AddSingleton<IConfiguration, TrustSelfSignedCertificatesConfiguration>();
            return mauiAppBuilder;
        }
    }
}
