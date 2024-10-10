using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Example.Model {

  /// <summary>
  /// SMILE Topology - a container such as a substation or cable box
  /// </summary>
  [DataContract]
  public class EquipmentContainer : IdentifiedObject {
    /// <summary>
    /// Gets or Sets Kind
    /// </summary>
    [DataMember(Name="kind", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "kind")]
    public string Kind { get; set; }

    /// <summary>
    /// Gets or Sets Wgs84longitude
    /// </summary>
    [DataMember(Name="wgs84longitude", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "wgs84longitude")]
    public double? Wgs84longitude { get; set; }

    /// <summary>
    /// Gets or Sets Wgs84latitude
    /// </summary>
    [DataMember(Name="wgs84latitude", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "wgs84latitude")]
    public double? Wgs84latitude { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class EquipmentContainer {\n");
      sb.Append("  Kind: ").Append(Kind).Append("\n");
      sb.Append("  Wgs84longitude: ").Append(Wgs84longitude).Append("\n");
      sb.Append("  Wgs84latitude: ").Append(Wgs84latitude).Append("\n");
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
