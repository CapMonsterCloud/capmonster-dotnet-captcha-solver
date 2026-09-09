using Newtonsoft.Json;

namespace Zennolab.CapMonsterCloud.Responses
{
    /// <summary>
    /// RecaptchaV3 recognition response
    /// </summary>
    public sealed class RecaptchaV3Response : RecaptchaResponseBase
    {
        /// <summary>
        /// User-Agent to resubmit with the token, when returned.
        /// </summary>
        [JsonProperty("userAgent")]
        public string UserAgent { get; set; }
    }
}
