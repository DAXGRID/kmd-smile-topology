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
  public class DataSetMember : IdentifiedObject {
    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [DataMember(Name="$type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "$type")]
    public string Type { get; set; }

    /// <summary>
    /// Gets or Sets TargetObject
    /// </summary>
    [DataMember(Name="targetObject", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "targetObject")]
    public string TargetObject { get; set; }

    /// <summary>
    /// Gets or Sets Change
    /// </summary>
    [DataMember(Name="change", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "change")]
    public ChangeSetMember Change { get; set; }

    /// <summary>
    /// Gets or Sets ReverseChange
    /// </summary>
    [DataMember(Name="reverseChange", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reverseChange")]
    public ObjectReverseModification ReverseChange { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DataSetMember {\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  TargetObject: ").Append(TargetObject).Append("\n");
      sb.Append("  Change: ").Append(Change).Append("\n");
      sb.Append("  ReverseChange: ").Append(ReverseChange).Append("\n");
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
