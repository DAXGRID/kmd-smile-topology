using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Example.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class TopologyNode : IdentifiedObject {
    /// <summary>
    /// Gets or Sets EquipmentContainer
    /// </summary>
    [DataMember(Name="equipmentContainer", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "equipmentContainer")]
    public string EquipmentContainer { get; set; }

    /// <summary>
    /// Gets or Sets BaseVoltage
    /// </summary>
    [DataMember(Name="baseVoltage", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "baseVoltage")]
    public int? BaseVoltage { get; set; }

    /// <summary>
    /// Gets or Sets Kind
    /// </summary>
    [DataMember(Name="kind", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "kind")]
    public TopologyNodeKind Kind { get; set; }


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
