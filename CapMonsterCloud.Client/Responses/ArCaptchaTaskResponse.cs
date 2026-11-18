using Newtonsoft.Json;

namespace Zennolab.CapMonsterCloud.Responses
{
    /// <summary>
    /// ARCaptcha recognition response
    /// </summary>
    public sealed class ArCaptchaTaskResponse : CaptchaResponseBase
    {
        /// <summary>
        /// ARCaptcha token to submit.
        /// </summary>
        [JsonProperty("token")]
        public string Value { get; set; }
    }
}
