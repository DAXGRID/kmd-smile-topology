using System;
using Newtonsoft.Json.Serialization;

namespace Example
{
    public sealed class TypeNameAssemblyExcludingSerializationBinder : ISerializationBinder
    {
        public static TypeNameAssemblyExcludingSerializationBinder Instance { get; }
            = new TypeNameAssemblyExcludingSerializationBinder();

        private TypeNameAssemblyExcludingSerializationBinder() { }

        public void BindToName(Type serializedType, out string assemblyName, out string typeName)
        {
            assemblyName = null;
            typeName = serializedType.Name;
        }

        public Type BindToType(string assemblyName, string typeName)
        {
            return Type.GetType(typeName);
        }
    }
}
