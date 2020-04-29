using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SPBDnevnik.JSONClasses;
using System.Globalization;
namespace SPBDnevnik.Workers
{
    public class JsonWorker
    {
        public static School FromJson(string json) => JsonConvert.DeserializeObject<School>(json, JSONClasses.Converter.Settings);

        internal static class Converter
        {
            public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
            {
                MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
                DateParseHandling = DateParseHandling.None,
                Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
            };
        }
    }
}
