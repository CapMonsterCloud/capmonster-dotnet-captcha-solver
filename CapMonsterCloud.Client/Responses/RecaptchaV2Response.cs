using Newtonsoft.Json;
using System.Collections.Generic;

namespace Zennolab.CapMonsterCloud.Responses
{
    /// <summary>
    /// RecaptchaV2 recognition response
    /// </summary>
    public sealed class RecaptchaV2Response : RecaptchaResponseBase
    {
        /// <summary>
        /// User-Agent to resubmit with the token, when returned.
        /// </summary>
        [JsonProperty("userAgent")]
        public string UserAgent { get; set; }

        /// <summary>
        /// Additional cookies, when returned.
        /// </summary>
        [JsonProperty("cookies", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Cookies { get; set; }
    }
}
