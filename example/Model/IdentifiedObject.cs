using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Example.Model {

  /// <summary>
  /// IEC/CIM base class that all identified CIM objects must implement
  /// </summary>
  [DataContract]
  public class IdentifiedObject {
    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [DataMember(Name="$type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "$type")]
    public string Type { get; set; }

    /// <summary>
    /// Master Resource Identifier - unique identified as defined by IEC CIM
    /// </summary>
    /// <value>Master Resource Identifier - unique identified as defined by IEC CIM</value>
    [DataMember(Name="mRID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mRID")]
    public Guid? MRID { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IdentifiedObject {\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  MRID: ").Append(MRID).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
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
