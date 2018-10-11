using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using TechTalk.SpecFlow;
using TestSkeleton2.ApiConnections;
using TestSkeleton2.TestWebMocks;

namespace TestSkeleton2.StepDefinitions
{
   [Binding]
   public sealed class StepDefinition1
   {
      // For additional details on SpecFlow step definitions see http://go.specflow.org/doc-stepdef
      [Given(@"There is '(.*)' existing blog")]
      public void GivenThereIsExisting( int numberOfBlogs ) {
         ScenarioContext.Current.Pending();
      }

      [When(@"Another url '(.*)' blogs are added")]
      public void WhenAnotherBlogsAreAdded( string blogUrl ) {
         Blog blog = new Blog {
            Url = blogUrl
         };
         
         var content = new StringContent(JsonConvert.SerializeObject(blog), Encoding.UTF8, "application/json");
         WebApiConnection.Post("blog", content);

      }

      [Then(@"There is '(.*)' after")]
      public void ThenThereIsAfter( int p0 ) {
         ScenarioContext.Current.Pending();
      }


   }
}
