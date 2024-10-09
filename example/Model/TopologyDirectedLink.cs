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
  public class TopologyDirectedLink : IdentifiedObject {
    /// <summary>
    /// Gets or Sets Parent
    /// </summary>
    [DataMember(Name="parent", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "parent")]
    public string Parent { get; set; }

    /// <summary>
    /// Gets or Sets Child
    /// </summary>
    [DataMember(Name="child", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "child")]
    public string Child { get; set; }

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
