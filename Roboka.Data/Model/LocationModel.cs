using Newtonsoft.Json;

namespace Roboka.Data.Model
{
    public class LocationModel
    {
        [JsonProperty("longitude")] public string Longitude { get; set; }
        [JsonProperty("latitude")] public string Latitude { get; set; }
    }
}
