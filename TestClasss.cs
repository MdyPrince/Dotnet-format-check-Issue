using System.Text.Json.Serialization;

namespace ConsoleApp1.TestClass
{
    public class TestClass
    {
        public class Field
        {
            [JsonPropertyName("text")]
            public string Text { get; set; }

            [JsonPropertyName("text2")]
            public int Text2 { get; set; }

            [JsonPropertyName("text3")]
            public int Text3 { get; set; }


        }

        [JsonPropertyName("property__1")]
        public string Property__1 { get; set; }

        [JsonPropertyName("property__2")]
        public int Property__2 { get; set; }

    }


    public class TestClassInfo
    {
        [JsonPropertyName("Property1")]
        public TestClass Property1 { get; set; }

        [JsonPropertyName("Property2")]
        public string Property2 { get; set; }

        public TestClassInfo()
        {
            Property1 = new TestClass();
            Property2 = "";
        }
    }

}

