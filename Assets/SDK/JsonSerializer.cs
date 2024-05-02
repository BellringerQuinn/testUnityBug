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
            Debug.Log("Serialized by JsonUtility: " + json);
        }

        public static void SerializeWithNewtonsoft()
        {
            ExampleObject obj = new ExampleObject("cool name", "stuff", "other stuff");
            JsonSerializerSettings serializerSettings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore
            };
            string json = JsonConvert.SerializeObject(obj, serializerSettings);
            Debug.Log("Serialized by Newtonsoft: " + json);
        }
        public static void SerializeComplexObjectWithJsonUtility()
        {
            ExampleObject obj = new ExampleObject("cool name", "stuff", "other stuff");
            ComplexObject complex = new ComplexObject("some string", obj, 5);
            string json = JsonUtility.ToJson(complex);
            Debug.Log("Complex object Serialized by JsonUtility: " + json);
        }

        public static void SerializeWithNewtonsoft()
        {
            ExampleObject obj = new ExampleObject("cool name", "stuff", "other stuff");
            ComplexObject complex = new ComplexObject("some string", obj, 5);
            JsonSerializerSettings serializerSettings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore
            };
            string json = JsonConvert.SerializeObject(complex, serializerSettings);
            Debug.Log("Complex object Serialized by Newtonsoft: " + json);
        }
    }
}