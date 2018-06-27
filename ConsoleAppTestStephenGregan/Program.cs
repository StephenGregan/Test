using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTestStephenGregan
{
    class Program
    {
        static void Main(string[] args)
        {
            //string json = @"[
            //                  {
            //                    'Title': 'Json.NET is awesome!',
            //                    'Author': {
            //                      'Name': 'James Newton-King',
            //                      'Twitter': '@JamesNK',
            //                      'Picture': '/jamesnk.png'
            //                    },
            //                    'Date': '2013-01-23T19:30:00',
            //                    'BodyHtml': '&lt;h3&gt;Title!&lt;/h3&gt;\r\n&lt;p&gt;Content!&lt;/p&gt;'
            //                  }
            //                ]";

            //dynamic blogPosts = JArray.Parse(json);

            //dynamic blogPost = blogPosts[0];

            //string title = blogPost.Title;

            //Console.WriteLine(title);
            //// Json.NET is awesome!

            //string author = blogPost.Author.Name;

            //Console.WriteLine(author);
            //// James Newton-King

            //DateTime postDate = blogPost.Date;

            //Console.WriteLine(postDate);
            //// 23/01/2013 7:30:00 p.m.

            string newJsonString = @"{
	};

            var valueSet = JsonConvert.DeserializeObject<Welcome>(newJsonString);

            Console.WriteLine("id: " + valueSet.Id);



            //        string jsonString = @"
            //    {
            //        ""JsonValues"": {
            //            ""id"": ""MyID"",
            //            ""values"": {
            //                ""value1"": {
            //                    ""id"": ""100"",
            //                    ""diaplayName"": ""MyValue1""
            //                },
            //                ""value2"": {
            //                    ""id"": ""200"",
            //                    ""diaplayName"": ""MyValue2""
            //                }
            //            }
            //        }
            //    }";

            //        var valueSet = JsonConvert.DeserializeObject<Wrapper>(jsonString).ValueSet;

            //        Console.WriteLine("id: " + valueSet.Id);
            //        foreach (KeyValuePair<string, Value> kvp in valueSet.Values)
            //        {
            //            Console.WriteLine(kvp.Key + " id: " + kvp.Value.Id);
            //            Console.WriteLine(kvp.Key + " name: " + kvp.Value.DisplayName);
            //        }
            //    }
            //}
        }
    }
}

