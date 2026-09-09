using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using Zennolab.CapMonsterCloud.Responses;

namespace Zennolab.CapMonsterCloud.Requests
{
    /// <summary>
    /// reCAPTCHA v3 Enterprise recognition request.
    /// The task is executed through CapMonster Cloud proxy servers (proxyless).
    /// </summary>
    /// <example>
    /// https://docs.capmonster.cloud/docs/captchas/recaptcha-v3-enterprise-task
    /// </example>
    public sealed class RecaptchaV3EnterpriseRequest : CaptchaRequestBase<RecaptchaV3Response>
    {
        /// <summary>
        /// Recognition task type
        /// </summary>
        public const string TaskType = "RecaptchaV3EnterpriseTask";

        /// <inheritdoc/>
        [JsonProperty("type", Required = Required.Always)]
        public override string Type => TaskType;

        /// <summary>
        /// Address of a webpage with captcha
        /// </summary>
        [JsonProperty("websiteURL", Required = Required.Always)]
        [Url]
        public string WebsiteUrl { get; set; }

        /// <summary>
        /// Recaptcha website key
        /// </summary>
        /// <example>
        /// 6Le0xVgUAAAAAIt20XEB4rVhYOODgTl00d8juDob
        /// </example>
        [JsonProperty("websiteKey", Required = Required.Always)]
        [StringLength(int.MaxValue, MinimumLength = 1)]
        public string WebsiteKey { get; set; }

        /// <summary>
        /// Minimum acceptable score, from 0.1 to 0.9. Optional.
        /// </summary>
        [JsonProperty("minScore", NullValueHandling = NullValueHandling.Ignore)]
        [Range(0.1, 0.9)]
        public double? MinScore { get; set; }

        /// <summary>
        /// Value of the action parameter passed to Google. The server defaults to "verify". Optional.
        /// </summary>
        [JsonProperty("pageAction", NullValueHandling = NullValueHandling.Ignore)]
        public string PageAction { get; set; }

        /// <summary>
        /// Set true to disable the reuse of previously obtained tokens (see "Token acceptance issues" in the docs). Optional.
        /// </summary>
        [JsonProperty("nocache", NullValueHandling = NullValueHandling.Ignore)]
        public bool? NoCache { get; set; }

        internal override bool UseNoCache => this.NoCache ?? false;
    }
}
