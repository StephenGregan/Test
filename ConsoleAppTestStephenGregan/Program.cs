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
	""id"": 10197,

    ""versionValue"": 4,
	""uuid"": ""c17229d8-6be6-4e5f-8799-c0776bc30f2a"",
	""createdBy"": ""GustavoCunha@translation.ie"",
	""createdDate"": ""01/06/18 16:44"",
	""lastModifiedBy"": ""GustavoCunha @translation.ie"",
	""lastModifiedDate"": ""01/06/18 16:44"",
	""company.id"": 1,
	""name"": ""Lycia Rodrigues"",
	""displayName"": ""Lycia Rodrigues (10197)"",
	""salutation"": "",
	""firstName"": ""Lycia"",
	""middleName"": "",
	""lastName"": ""Rodrigues"",
	""nickName"": "",
	""suffix"": "",
	""gender.id"": 2,
	""businessUnit.id"": "",
	""dateOfBirth"": ""06/01/95"",
	""contactTypes"": [],
	""accountingReference"": ""10197"",
	""referenceId"": ""10197"",
	""languageMappings"": [{
		""id"": 17832,
		""contact.id"": 10197,
		""language.id"": 137,
		""language"": {
			""id"": 137,
			""label"": ""Portuguese"",
			""description"": ""Portuguese"",
			""alternates"": null,
			""value"": ""pt"",
			""subtag"": ""pt"",
			""iso639_3Tag"": ""por"",
			""type"": ""language"",
			""alias"": null,
			""enabled"": true

        }";

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

