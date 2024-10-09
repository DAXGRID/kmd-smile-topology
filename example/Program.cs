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
        var jsonLines1 = File.ReadAllLines("./example/data/smile_topology_delta_0_intial.jsonl");
        var jsonLines2 = File.ReadAllLines("./example/data/smile_topology_delta_1_changes.jsonl");
        var jsonLines3 = File.ReadAllLines("./kmd-smile-topology/example/data/smile_topology_delta_2_changes.jsonl");
        var jsonLines4 = File.ReadAllLines("./kmd-smile-topology/example/data/smile_topology_delta_3_changes.jsonl");

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
    }
}
