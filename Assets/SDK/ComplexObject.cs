using System;

namespace SerializationExample
{
    [Serializable]
    public class ComplexObject
    {
        public string SomeValue;
        public NestedObject<ExampleObject> SomeObject;
        public int SomeNumber;

        public ComplexObject(string someValue, NestedObject<ExampleObject> someObject, int someNumber)
        {
            this.SomeValue = someValue;
            this.SomeObject = someObject;
            this.SomeNumber = someNumber;
        }
    }
}