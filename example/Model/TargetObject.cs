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
  public class TargetObject {
    /// <summary>
    /// Gets or Sets ReferenceType
    /// </summary>
    [DataMember(Name="referenceType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "referenceType")]
    public string ReferenceType { get; set; }

    /// <summary>
    /// Gets or Sets _Ref
    /// </summary>
    [DataMember(Name="ref", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ref")]
    public string _Ref { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TargetObject {\n");
      sb.Append("  ReferenceType: ").Append(ReferenceType).Append("\n");
      sb.Append("  _Ref: ").Append(_Ref).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
