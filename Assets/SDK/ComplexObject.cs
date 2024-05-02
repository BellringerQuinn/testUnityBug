namespace SerializationExample
{
    [System.Serializable]
    public class ComplexObject
    {
        public string SomeValue;
        public ExampleObject SomeObject;
        public int SomeNumber;

        public ComplexObject(string someValue, ExampleObject someObject, int someNumber)
        {
            this.SomeValue = someValue;
            this.SomeObject = someObject;
            this.SomeNumber = someNumber;
        }
    }
}