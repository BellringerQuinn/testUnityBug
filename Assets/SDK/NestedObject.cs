using System;

namespace SerializationExample
{
    [Serializable]
    public class NestedObject<T>
    {
        public string ObjectType;
        public T ObjectThatIsNested;

        public NestedObject(string objectType, T objectThatIsNested)
        {
            ObjectType = objectType;
            ObjectThatIsNested = objectThatIsNested;
        }
    }
}