using Newtonsoft.Json;
using System.Collections.Generic;

namespace NkustAqiConsole
{
    public class AqiDataRoot
    {
        [JsonProperty("records")]
        public List<AqiRecord> Records { get; set; } = null!;     }

    public class AqiRecord
    {
        [JsonProperty("sitename")]
        public string SiteName { get; set; } = null!; 
        [JsonProperty("aqi_value")]
        public string AqiValueString { get; set; } = null!;
        public int AqiValue
        {
            get
            {
                if (int.TryParse(AqiValueString, out int aqi))
                {
                    return aqi;
                }
                return 0; 
            }
        }
    }
}