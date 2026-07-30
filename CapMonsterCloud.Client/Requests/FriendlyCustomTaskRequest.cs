using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Zennolab.CapMonsterCloud.Requests
{
    /// <summary>
    /// Friendly CustomTask recognition request.
    /// </summary>
    /// <example>
    /// https://docs.capmonster.cloud/docs/captchas/friendly-task/
    /// </example>
    public sealed class FriendlyCustomTaskRequest : CustomTaskRequestBase
    {
        /// <inheritdoc/>
        public override string Class => "friendly";

        /// <summary>
        /// Friendly Captcha key
        /// </summary>
        [JsonProperty("websiteKey", Required = Required.Always)]
        [StringLength(int.MaxValue, MinimumLength = 0)]
        public string WebsiteKey { get; set; }

        /// <summary>
        ///
        /// These values will be set to Metadata property.
        ///
        /// - apiGetLib: "apiGetLib": "..."
        /// Field is required.
        /// URL of the JS file. Specify the URL depending on the captcha version:
        /// V1: apiGetLib = https://cdn.jsdelivr.net/npm/friendly-challenge@X.Y.Z/widget.module.min.js, where X.Y.Z is the client version from the x-frc-client header.
        /// V2: apiGetLib = URL of the site.min.js file loaded on the page.Example: https://cdn.jsdelivr.net/npm/@friendlycaptcha/sdk@X.Y.Z/site.min.js, where X.Y.Z is the client version.
        ///
        /// </summary>
        public FriendlyCustomTaskRequest(string apiGetLib) => Metadata = new { apiGetLib };
    }
}
