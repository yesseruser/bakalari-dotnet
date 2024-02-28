using System;
using System.Linq;
using System.Net.Http;

namespace Bakalari.NET
{
    public static class HttpClientGenerator
    {
        /// <summary>
        /// Create HttpClient by url to school's Bakaláři system. Make sure to add ".cz"!
        /// </summary>
        /// <param name="url">The url to the user's school's Bakaláři system. Example: "https://bakalari.example.cz"</param>
        /// <returns>An HttpClient to pass into methods of other modules of this wrapper or to make your own API request.</returns>
        public static HttpClient CreateByUrl(string url)
        {
            if (url.Contains("http://"))
            {
                url = url.Insert(4, "s");
            }
            else if (!url.Contains("https://"))
            {
                url = url.Insert(0, "https://");
            }

            var client = new HttpClient()
            {
                BaseAddress = new Uri(url)
            };

            return client;
        }

        /// <summary>
        /// Create HttpClient by school name.
        /// </summary>
        /// <param name="name">The name of the school in the url.
        /// Example: "example" (returns client with url "https://bakalari.example.cz")</param>
        /// <returns>An HttpClient to pass into methods of other modules of this wrapper or to make your own API request.</returns>
        public static HttpClient CreateBySchoolName(string name)
        {
            var client = new HttpClient()
            {
                BaseAddress = new Uri($"https://bakalari.{name}.cz")
            };

            return client;
        }
    }
}