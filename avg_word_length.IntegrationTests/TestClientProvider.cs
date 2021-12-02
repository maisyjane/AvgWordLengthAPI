using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace avg_word_length.IntegrationTests
{
    public class TestClientProvider
    {
        public HttpClient Client { get; private set; }
        public TestClientProvider()
        {
            //CREATE INSTANCE OF TEST SERVER
            var server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
            //CREATE CLIENT
            Client = server.CreateClient();
        }
    }
}
