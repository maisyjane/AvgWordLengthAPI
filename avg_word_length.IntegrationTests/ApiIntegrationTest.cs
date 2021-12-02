using System;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace avg_word_length.IntegrationTests
{
    public class ApiIntegrationTest
    {
        [Fact]
        public async Task TestGetWithParameters()
        {
            var client = new TestClientProvider().Client;
            var response = await client.GetAsync("/test");
            response.EnsureSuccessStatusCode();
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task TestGetWithBadParameters()
        {
            var client = new TestClientProvider().Client;
            var response = await client.GetAsync("/12345");
            Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);
        }

        [Fact]
        public async Task TestGetWithNoParameters()
        {
            var client = new TestClientProvider().Client;
            var response = await client.GetAsync("/");
            Assert.Equal(HttpStatusCode.NotFound, response.StatusCode);
        }
    }
}
