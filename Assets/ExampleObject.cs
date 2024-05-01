using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace  SerializationExample
{
    [SerializeField]
    public class ExampleObject
    {
        public string name { get; private set; }
        public string someValue { get; private set; }
        public string SomeOtherValue { get; private set; }

        public ExampleObject(string name, string someValue, string someOtherValue)
        {
            this.name = name;
            this.someValue = someValue;
            SomeOtherValue = someOtherValue;
        }
    }
}
