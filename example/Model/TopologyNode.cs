using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Example.Model {

  /// <summary>
  /// SMILE Topology - a network node such as a network injection, power transforer, busbar node, or start of a feeder
  /// </summary>
  [DataContract]
  public class TopologyNode : IdentifiedObject {
    /// <summary>
    /// Reference to an equipment container containing this topology node
    /// </summary>
    /// <value>Reference to an equipment container containing this topology node</value>
    [DataMember(Name="EquipmentContainer", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "EquipmentContainer")]
    public Guid? EquipmentContainer { get; set; }

    /// <summary>
    /// Base voltage in volts
    /// </summary>
    /// <value>Base voltage in volts</value>
    [DataMember(Name="baseVoltage", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "baseVoltage")]
    public int? BaseVoltage { get; set; }

    /// <summary>
    /// Gets or Sets Kind
    /// </summary>
    [DataMember(Name="kind", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "kind")]
    public string Kind { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TopologyNode {\n");
      sb.Append("  EquipmentContainer: ").Append(EquipmentContainer).Append("\n");
      sb.Append("  BaseVoltage: ").Append(BaseVoltage).Append("\n");
      sb.Append("  Kind: ").Append(Kind).Append("\n");
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
