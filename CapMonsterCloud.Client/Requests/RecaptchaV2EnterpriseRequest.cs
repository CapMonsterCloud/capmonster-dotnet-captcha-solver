using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using Zennolab.CapMonsterCloud.Responses;
using System.Collections.Generic;

namespace Zennolab.CapMonsterCloud.Requests
{
    /// <summary>
    /// Recaptcha V2 Enterprise recognition request.
    /// </summary>
    public sealed class RecaptchaV2EnterpriseRequest : CaptchaRequestBaseWithProxy<RecaptchaV2EnterpriseResponse>
    {
        /// <summary>
        /// Recognition task type
        /// </summary>
        public const string TaskType = "RecaptchaV2EnterpriseTask";

        /// <inheritdoc/>
        [JsonProperty("type", Required = Required.Always)]
        public override sealed string Type => TaskType;

        /// <summary>
        /// Address of a webpage with Google ReCaptcha
        /// </summary>
        [JsonProperty("websiteURL", Required = Required.Always)]
        [Url]
        public string WebsiteUrl { get; set; }

        /// <summary>
        /// Recaptcha website key.
        /// <![CDATA[<div class="g-recaptcha" data-sitekey="THAT_ONE"></div>]]>
        /// </summary>
        [JsonProperty("websiteKey", Required = Required.Always)]
        [StringLength(int.MaxValue, MinimumLength = 1)]
        public string WebsiteKey { get; set; }

        /// <summary>
        /// Additional parameters which should be passed to "grecaptcha.enterprise.render" method along with sitekey.
        /// Example of what you should search for:
        /// <![CDATA[
        /// grecaptcha.enterprise.render("some-div-id", {
        ///   sitekey: "6Lc_aCMTAAAAABx7u2N0D1XnVbI_v6ZdbM6rYf16",
        ///   theme: "dark",
        ///   s: "2JvUXHNTnZl1Jb6WEvbDyBMzrMTR7oQ78QRhBcG07rk9bpaAaE0LRq1ZeP5NYa0N...ugQA"
        ///   });
        /// ]]>
        /// In this example, you will notice a parameter "s" which is not documented, but obviously required.
        /// Send it to the API, so that we render the Recaptcha widget with this parameter properly.
        /// </summary>
        [JsonProperty("enterprisePayload")]
        [StringLength(int.MaxValue, MinimumLength = 1)]
        public string EnterprisePayload { get; set; }

        /// <summary>
        /// Some custom implementations may contain additional "data-s" parameter in ReCaptcha2 div, which is in fact a one-time token and must be grabbed every time you want to solve a ReCaptcha2.
        /// <![CDATA[<div class="g-recaptcha" data-sitekey="some sitekey" data-s="THIS_ONE"></div>]]>
        /// </summary>
        [JsonProperty("recaptchaDataSValue")]
        public string DataSValue { get; set; }

        /// <summary>
        /// Set true if the site only accepts a portion of the tokens from CapMonster Cloud.
        /// https://zenno.link/doc-token-accept-en
        /// </summary>
        [JsonProperty("nocache", NullValueHandling = NullValueHandling.Ignore)]
        public bool? NoCache { get; set; }

        internal override bool UseNoCache => this.NoCache ?? false;

        /// <summary>
        /// Domain to load reCAPTCHA Enterprise from (e.g. www.google.com or www.recaptcha.net).
        /// </summary>
        [JsonProperty("apiDomain", NullValueHandling = NullValueHandling.Ignore)]
        public string ApiDomain { get; set; }

        /// <summary>
        /// Value of the action parameter sent to Google.
        /// </summary>
        /// <example>verify</example>
        [JsonProperty("pageAction", NullValueHandling = NullValueHandling.Ignore)]
        public string PageAction { get; set; }

        /// <summary>
        /// Additional cookies, format: "name1=value1; name2=value2".
        /// </summary>
        [JsonProperty("cookies", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(Json.DictionaryToSemicolonSplittedStringConverter))]
        public IDictionary<string, string> Cookies { get; set; }

        /// <summary>
        /// Browser User-Agent to emulate. Pass only a current Windows OS UA.
        /// </summary>
        [JsonProperty("userAgent", NullValueHandling = NullValueHandling.Ignore)]
        public string UserAgent { get; set; }
    }
}