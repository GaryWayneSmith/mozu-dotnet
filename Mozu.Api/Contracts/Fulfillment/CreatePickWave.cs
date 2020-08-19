using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Mozu.Api.Contracts.Fulfillment {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class CreatePickWave {
    /// <summary>
    /// Gets or Sets AllowEmptyWave
    /// </summary>
    [DataMember(Name="allowEmptyWave", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "allowEmptyWave")]
    public bool? AllowEmptyWave { get; set; }

    /// <summary>
    /// Gets or Sets Attributes
    /// </summary>
    [DataMember(Name="attributes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "attributes")]
    public Dictionary<string, Object> Attributes { get; set; }

    /// <summary>
    /// Gets or Sets BinRanges
    /// </summary>
    [DataMember(Name="binRanges", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "binRanges")]
    public List<PickWaveBinRange> BinRanges { get; set; }

    /// <summary>
    /// Gets or Sets FulfillmentLocationCode
    /// </summary>
    [DataMember(Name="fulfillmentLocationCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fulfillmentLocationCode")]
    public string FulfillmentLocationCode { get; set; }

    /// <summary>
    /// Gets or Sets IncludeZeroInventory
    /// </summary>
    [DataMember(Name="includeZeroInventory", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "includeZeroInventory")]
    public bool? IncludeZeroInventory { get; set; }

    /// <summary>
    /// Gets or Sets LockWave
    /// </summary>
    [DataMember(Name="lockWave", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lockWave")]
    public bool? LockWave { get; set; }

    /// <summary>
    /// Gets or Sets MaxShipments
    /// </summary>
    [DataMember(Name="maxShipments", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "maxShipments")]
    public int? MaxShipments { get; set; }

    /// <summary>
    /// Gets or Sets PickWaveType
    /// </summary>
    [DataMember(Name="pickWaveType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pickWaveType")]
    public string PickWaveType { get; set; }

    /// <summary>
    /// Gets or Sets Products
    /// </summary>
    [DataMember(Name="products", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "products")]
    public List<PickWaveProductMatch> Products { get; set; }

    /// <summary>
    /// Gets or Sets ShipmentDateEnd
    /// </summary>
    [DataMember(Name="shipmentDateEnd", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shipmentDateEnd")]
    public DateTime? ShipmentDateEnd { get; set; }

    /// <summary>
    /// Gets or Sets ShipmentDateStart
    /// </summary>
    [DataMember(Name="shipmentDateStart", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shipmentDateStart")]
    public DateTime? ShipmentDateStart { get; set; }

    /// <summary>
    /// Gets or Sets ShipmentType
    /// </summary>
    [DataMember(Name="shipmentType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shipmentType")]
    public string ShipmentType { get; set; }

    /// <summary>
    /// Gets or Sets ShippingOption
    /// </summary>
    [DataMember(Name="shippingOption", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shippingOption")]
    public string ShippingOption { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CreatePickWave {\n");
      sb.Append("  AllowEmptyWave: ").Append(AllowEmptyWave).Append("\n");
      sb.Append("  Attributes: ").Append(Attributes).Append("\n");
      sb.Append("  BinRanges: ").Append(BinRanges).Append("\n");
      sb.Append("  FulfillmentLocationCode: ").Append(FulfillmentLocationCode).Append("\n");
      sb.Append("  IncludeZeroInventory: ").Append(IncludeZeroInventory).Append("\n");
      sb.Append("  LockWave: ").Append(LockWave).Append("\n");
      sb.Append("  MaxShipments: ").Append(MaxShipments).Append("\n");
      sb.Append("  PickWaveType: ").Append(PickWaveType).Append("\n");
      sb.Append("  Products: ").Append(Products).Append("\n");
      sb.Append("  ShipmentDateEnd: ").Append(ShipmentDateEnd).Append("\n");
      sb.Append("  ShipmentDateStart: ").Append(ShipmentDateStart).Append("\n");
      sb.Append("  ShipmentType: ").Append(ShipmentType).Append("\n");
      sb.Append("  ShippingOption: ").Append(ShippingOption).Append("\n");
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
