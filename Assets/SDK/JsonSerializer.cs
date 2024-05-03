using UnityEngine;
using Newtonsoft.Json;

namespace SerializationExample
{
    public class JsonSerializer
    {
        public static string SerializeWithJsonUtility()
        {
            ExampleObject obj = new ExampleObject("cool name", "stuff", "other stuff");
            string json = JsonUtility.ToJson(obj);
            Debug.Log("Serialized by JsonUtility: " + json);
            return json;
        }

        public static string SerializeWithNewtonsoft()
        {
            ExampleObject obj = new ExampleObject("cool name", "stuff", "other stuff");
            JsonSerializerSettings serializerSettings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore
            };
            string json = JsonConvert.SerializeObject(obj, serializerSettings);
            Debug.Log("Serialized by Newtonsoft: " + json);
            return json;
        }
        public static string SerializeComplexObjectWithJsonUtility()
        {
            ExampleObject obj = new ExampleObject("cool name", "stuff", "other stuff");
            NestedObject<ExampleObject> nested = new NestedObject<ExampleObject>("ExampleObject", obj);
            ComplexObject complex = new ComplexObject("some string", nested, 5);
            string json = JsonUtility.ToJson(complex);
            Debug.Log("Complex object Serialized by JsonUtility: " + json);
            return json;
        }

        public static string SerializeComplexObjectWithNewtonsoft()
        {
            ExampleObject obj = new ExampleObject("cool name", "stuff", "other stuff");
            NestedObject<ExampleObject> nested = new NestedObject<ExampleObject>("ExampleObject", obj);
            ComplexObject complex = new ComplexObject("some string", nested, 5);
            JsonSerializerSettings serializerSettings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore
            };
            string json = JsonConvert.SerializeObject(complex, serializerSettings);
            Debug.Log("Complex object Serialized by Newtonsoft: " + json);
            return json;
        }

        public static T DeserializeJsonWithJsonUtility<T>(string json)
        {
            T obj = JsonUtility.FromJson<T>(json);
            return obj;
        }

        public static T DeserializeJsonWithNewtonsoft<T>(string json)
        {
            T obj = JsonConvert.DeserializeObject<T>(json);
            return obj;
        }
    }
}