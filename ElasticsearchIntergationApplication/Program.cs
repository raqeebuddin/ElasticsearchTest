﻿using System;
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
        static void Main(string[] args)
        {
            var settings = new ConnectionSettings(new Uri("http://localhost:9200")).DefaultIndex("people");
            var client = new ElasticClient(settings);

            //index a single poco

            var person = new Person
            {
                FirstName = "Martijn1",
                LastName = "Laarman"
            };

            var indexResponse = client.IndexDocument(person);

            var test = "test";


        }
    }
}
