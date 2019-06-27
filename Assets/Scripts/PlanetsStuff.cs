using Newtonsoft.Json;

namespace Assets.Scripts
{
    /// <summary>
    /// Model for parsing planets.json
    /// </summary>
    public class PlanetsStuff
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("namerus")]
        public string Namerus { get; set; }

        [JsonProperty("dist")]
        public string Dist { get; set; }

        [JsonProperty("weight")]
        public string Weight { get; set; }

        [JsonProperty("desc")]
        public string Desc { get; set; }
    }
}