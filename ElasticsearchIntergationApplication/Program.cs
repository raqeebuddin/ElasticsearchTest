using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Elasticsearch.Net;
using ElasticsearchIntergationApplication.Model;
using Nest;
using Newtonsoft;

namespace ElasticsearchIntergationApplication
{
    class Program
    {
        static ElasticClient client;
        static void Main(string[] args)
        {
            var settings = new ConnectionSettings(new Uri("http://localhost:9200")).DefaultIndex("people");
            client = new ElasticClient(settings);

            //index a single poco

            var person = new Person
            {
                FirstName = "MartijnAsync",
                LastName = "Laarman"
            };

            //var indexResponse = client.IndexDocument(person);

            var taskOne = IndexAsync(person).Result;
    

        }

        public static async Task<IIndexResponse> IndexAsync(Person person)
        {
            var asyncIndexResponse = await client.IndexDocumentAsync(person);
            return asyncIndexResponse;
        }
    }
}
