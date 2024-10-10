using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Example.Model {

  /// <summary>
  /// SMILE Topology - a directed parent-child link between two topology nodes
  /// </summary>
  [DataContract]
  public class TopologyDirectedLink : IdentifiedObject {
    /// <summary>
    /// Reference to the parent topology node
    /// </summary>
    /// <value>Reference to the parent topology node</value>
    [DataMember(Name="Parent", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Parent")]
    public Guid? Parent { get; set; }

    /// <summary>
    /// Reference to the child topology node
    /// </summary>
    /// <value>Reference to the child topology node</value>
    [DataMember(Name="Child", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Child")]
    public Guid? Child { get; set; }

    /// <summary>
    /// Gets or Sets SwitchStatus
    /// </summary>
    [DataMember(Name="switchStatus", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "switchStatus")]
    public string SwitchStatus { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TopologyDirectedLink {\n");
      sb.Append("  Parent: ").Append(Parent).Append("\n");
      sb.Append("  Child: ").Append(Child).Append("\n");
      sb.Append("  SwitchStatus: ").Append(SwitchStatus).Append("\n");
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
