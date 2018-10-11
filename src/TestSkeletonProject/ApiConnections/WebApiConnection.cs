using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace TestSkeleton2.ApiConnections
{
   public static class WebApiConnection
   {
      private static HttpClient __HttpClient = new HttpClient();
      private static string __ApiEndpoint = ConfigurationManager.AppSettings["WebApiEndpoint"];

      public static Task<HttpResponseMessage> Post( string url, StringContent content ) {

         var message = new HttpRequestMessage() {
            Method = HttpMethod.Post,
            RequestUri = new Uri(__ApiEndpoint + url),
            Content = content
         };
         message.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

         return __HttpClient.SendAsync(message);
      }
   }
}
