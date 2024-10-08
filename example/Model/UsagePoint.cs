using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using CIM.PhysicalNetworkModel;

namespace Example.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class UsagePoint : IdentifiedObject {
    /// <summary>
    /// Gets or Sets TopologyNode
    /// </summary>
    [DataMember(Name="topologyNode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "topologyNode")]
    public string TopologyNode { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UsagePoint {\n");
      sb.Append("  TopologyNode: ").Append(TopologyNode).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public  new string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
