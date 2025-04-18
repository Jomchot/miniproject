// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using miniproject.Model;
//
//    var students = Students.FromJson(jsonString);

namespace miniproject.Model
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class Students
    {
        [JsonProperty("student_id")]
        public string StudentId { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("faculty")]
        public string Faculty { get; set; }

        [JsonProperty("major")]
        public string Major { get; set; }

        [JsonProperty("year")]
        public long Year { get; set; }

        [JsonProperty("gpa")]
        public long Gpa { get; set; }

        [JsonProperty("courses_enrolled")]
        public List<CoursesEnrolled> CoursesEnrolled { get; set; }
    }

    public partial class CoursesEnrolled
    {
        [JsonProperty("course_id")]
        public string CourseId { get; set; }

        [JsonProperty("course_name")]
        public string CourseName { get; set; }

        [JsonProperty("year")]
        public long Year { get; set; }

        [JsonProperty("term")]
        public long Term { get; set; }

        [JsonProperty("credits")]
        public long Credits { get; set; }
    }

    public partial class Students
    {
        public static List<Students> FromJson(string json) => JsonConvert.DeserializeObject<List<Students>>(json, miniproject.Model.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this List<Students> self) => JsonConvert.SerializeObject(self, miniproject.Model.Converter.Settings);
    }

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
