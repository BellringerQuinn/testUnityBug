using UnityEngine;
using Newtonsoft.Json;

namespace SerializationExample
{
    public class JsonSerializer
    {
        public static void SerializeWithJsonUtility()
        {
            ExampleObject obj = new ExampleObject("cool name", "stuff", "other stuff");
            string json = JsonUtility.ToJson(obj);
            Debug.Log(json);
        }

        public static void SerializeWithNewtonsoft()
        {
            ExampleObject obj = new ExampleObject("cool name", "stuff", "other stuff");
            JsonSerializerSettings serializerSettings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore
            };
            string json = JsonConvert.SerializeObject(obj, serializerSettings);
            Debug.Log(json);
        }
    }
}