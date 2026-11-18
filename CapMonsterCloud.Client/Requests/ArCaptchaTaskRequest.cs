using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using Zennolab.CapMonsterCloud.Responses;

namespace Zennolab.CapMonsterCloud.Requests
{
    /// <summary>
    /// ARCaptcha recognition request.
    /// </summary>
    /// <example>
    /// https://docs.capmonster.cloud/docs/captchas/arcaptcha-task/
    /// </example>
    public sealed class ArCaptchaTaskRequest : CaptchaRequestBaseWithProxy<ArCaptchaTaskResponse>
    {
        /// <summary>
        /// Recognition task type
        /// </summary>
        public const string TaskType = "ArCaptchaTask";

        /// <inheritdoc/>
        [JsonProperty("type", Required = Required.Always)]
        public override sealed string Type => TaskType;

        /// <summary>
        /// The address of the main page where the captcha is located.
        /// </summary>
        [JsonProperty("websiteURL", Required = Required.Always)]
        [Url]
        public string WebsiteUrl { get; set; }

        /// <summary>
        /// The value of the siteKey parameter found on the page.
        /// </summary>
        [JsonProperty("websiteKey", Required = Required.Always)]
        [StringLength(int.MaxValue, MinimumLength = 1)]
        public string WebsiteKey { get; set; }

        /// <summary>
        /// True if the captcha is invisible, meaning it has a hidden verification field.
        /// </summary>
        [JsonProperty("isInvisible", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsInvisible { get; set; }

        /// <summary>
        /// Browser User-Agent.
        /// </summary>
        [JsonProperty("userAgent")]
        public string UserAgent { get; set; }
    }
}
