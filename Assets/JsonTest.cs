using System.Collections;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using UnityEngine;

namespace JsonGeneratorTest
{
    public class TestData
    {
        public int Data { get; set; }
        public string Description { get; set; }
    }

    [JsonSerializable(typeof(TestData), GenerationMode = JsonSourceGenerationMode.Metadata)]
    internal partial class MyJsonContext : JsonSerializerContext
    {
    }

    public class JsonTest : MonoBehaviour
    {

        void Start()
        {
            var str = JsonSerializer.Serialize(new TestData() { Data = 1, Description = "Desc" }, MyJsonContext.Default.TestData);
            Debug.Log(str);
        }

    }
}