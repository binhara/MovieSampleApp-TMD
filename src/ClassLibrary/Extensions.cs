using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace ClassLibrary
{
    public static class Extensions
    {
        public static string ToJson(this object obj)
        {
            if (obj == null)
                return null;

            var settings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
                DefaultValueHandling = DefaultValueHandling.Ignore
            };
            string json = JsonConvert.SerializeObject(obj, Formatting.Indented, settings);
            Debug.WriteLine("Serialization; type={0}; json={1}", obj.GetType(), json);
            return json;
        }

        public static T ToObject<T>(this string value) where T : new()
        {
            if (value == null)
                return default(T);

            try
            {
                return JsonConvert.DeserializeObject<T>(value);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
                return default(T);
            }
        }

       public static object AssertNotNull(this object obj, string name)
        {
            if (obj == null)
                throw new ArgumentNullException(name);
            return obj;
        }
    }
}
