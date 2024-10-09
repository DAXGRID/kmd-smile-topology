using Example.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;

namespace Example;

internal static class Program
{
    public static void Main()
    {
        // Insert the base path of the project here example:
        // /home/myuser/projects/dax/kmd-smile-topology/example
        var basePath = "";
        var jsonLines1 = File.ReadAllLines($"{basePath}/data/smile_topology_delta_0_intial.jsonl");
        var jsonLines2 = File.ReadAllLines($"{basePath}/data/smile_topology_delta_1_changes.jsonl");
        var jsonLines3 = File.ReadAllLines($"{basePath}/data/smile_topology_delta_2_changes.jsonl");
        var jsonLines4 = File.ReadAllLines($"{basePath}/data/smile_topology_delta_3_changes.jsonl");

        var settings = new JsonSerializerSettings
        {
            TypeNameHandling = TypeNameHandling.Objects,
            NullValueHandling = NullValueHandling.Ignore,
            ContractResolver = new DefaultContractResolver
            {
                NamingStrategy = new CamelCaseNamingStrategy()
            },
            Converters =
            {
                new StringEnumConverter()
            },
            SerializationBinder = TypeNameAssemblyExcludingSerializationBinder.Instance,
            Binder = new ShortNameBinder(),
        };

        void ProcessLines(IEnumerable<string> jsonLines)
        {
            foreach (var jsonLine in jsonLines1)
            {
                var identifiedModel = JsonConvert.DeserializeObject<IdentifiedObject>(jsonLine, settings);
                Console.WriteLine(JsonConvert.SerializeObject(identifiedModel));
            }
        }

        ProcessLines(jsonLines1);
        ProcessLines(jsonLines2);
        ProcessLines(jsonLines3);
        ProcessLines(jsonLines4);
    }
}
