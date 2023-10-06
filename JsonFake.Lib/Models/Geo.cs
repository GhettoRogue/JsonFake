using System.Text.Json.Serialization;

namespace JsonFake.Lib.Models;

public record Geo
{
    [JsonPropertyName("lat")]
    public string Lat { get; set; }

    [JsonPropertyName("lng")]
    public string Lng { get; set; }
}