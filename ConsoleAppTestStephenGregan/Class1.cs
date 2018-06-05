using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace ConsoleAppTestStephenGregan
//{
    //    class Wrapper
    //   {
    //    [JsonProperty("JsonValues")]
    //    public ValueSet ValueSet { get; set; }
    //}

    //class ValueSet
    //{
    //    [JsonProperty("id")]
    //    public string Id { get; set; }
    //    [JsonProperty("values")]
    //    public Dictionary<string, Value> Values { get; set; }
    //}

    //class Value
    //{
    //    [JsonProperty("id")]
    //    public string Id { get; set; }
    //    [JsonProperty("diaplayName")]
    //    public string DisplayName { get; set; }
    //}

    // To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
    //
    //    using ConsoleAppTestStephenGregan;
    //
    //    var welcome = Welcome.FromJson(jsonString);

    namespace ConsoleAppTestStephenGregan
    {
        using System;
        using System.Collections.Generic;

        using System.Globalization;
        using Newtonsoft.Json;
        using Newtonsoft.Json.Converters;

    class Wrapper
    {
        [JsonProperty("JsonWelcome")]
        public Welcome Welcome { get; set; }
    }

    public partial class Welcome
        {
            [JsonProperty("id")]
            public long Id { get; set; }

            [JsonProperty("versionValue")]
            public long VersionValue { get; set; }

            [JsonProperty("uuid")]
            public string Uuid { get; set; }

            [JsonProperty("createdBy")]
            public string CreatedBy { get; set; }

            [JsonProperty("createdDate")]
            public string CreatedDate { get; set; }

            [JsonProperty("lastModifiedBy")]
            public string LastModifiedBy { get; set; }

            [JsonProperty("lastModifiedDate")]
            public string LastModifiedDate { get; set; }

            [JsonProperty("company.id")]
            public long CompanyId { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("displayName")]
            public string DisplayName { get; set; }

            [JsonProperty("salutation")]
            public string Salutation { get; set; }

            [JsonProperty("firstName")]
            public string FirstName { get; set; }

            [JsonProperty("middleName")]
            public string MiddleName { get; set; }

            [JsonProperty("lastName")]
            public string LastName { get; set; }

            [JsonProperty("nickName")]
            public string NickName { get; set; }

            [JsonProperty("suffix")]
            public string Suffix { get; set; }

            [JsonProperty("gender.id")]
            public long GenderId { get; set; }

            [JsonProperty("businessUnit.id")]
            public string BusinessUnitId { get; set; }

            [JsonProperty("dateOfBirth")]
            public string DateOfBirth { get; set; }

            [JsonProperty("contactTypes")]
            public object[] ContactTypes { get; set; }

            [JsonProperty("accountingReference")]
            public string AccountingReference { get; set; }

            [JsonProperty("referenceId")]
            public string ReferenceId { get; set; }

            [JsonProperty("languageMappings")]
            public LanguageMapping[] LanguageMappings { get; set; }
        }

        public partial class LanguageMapping
        {
            [JsonProperty("id")]
            public long Id { get; set; }

            [JsonProperty("contact.id")]
            public long ContactId { get; set; }

            [JsonProperty("language.id")]
            public long LanguageId { get; set; }

            [JsonProperty("language")]
            public Language Language { get; set; }
        }

        public partial class Language
        {
            [JsonProperty("id")]
            public long Id { get; set; }

            [JsonProperty("label")]
            public string Label { get; set; }

            [JsonProperty("description")]
            public string Description { get; set; }

            [JsonProperty("alternates")]
            public object Alternates { get; set; }

            [JsonProperty("value")]
            public string Value { get; set; }

            [JsonProperty("subtag")]
            public string Subtag { get; set; }

            [JsonProperty("iso639_3Tag")]
            public string Iso6393Tag { get; set; }

            [JsonProperty("type")]
            public string Type { get; set; }

            [JsonProperty("alias")]
            public object Alias { get; set; }

            [JsonProperty("enabled")]
            public bool Enabled { get; set; }
        }

        public partial class Welcome
        {
            public static Welcome FromJson(string json) => JsonConvert.DeserializeObject<Welcome>(json, ConsoleAppTestStephenGregan.Converter.Settings);
        }

        public static class Serialize
        {
            public static string ToJson(this Welcome self) => JsonConvert.SerializeObject(self, ConsoleAppTestStephenGregan.Converter.Settings);
        }

        internal static class Converter
        {
            public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
            {
                MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
                DateParseHandling = DateParseHandling.None,
                Converters = {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
            };
        }
    }


