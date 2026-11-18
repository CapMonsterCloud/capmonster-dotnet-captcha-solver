using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Zennolab.CapMonsterCloud.Requests
{
    /// <summary>
    /// HeyTap CustomTask recognition request
    /// </summary>
    /// <example>
    /// https://docs.capmonster.cloud/docs/captchas/heytap-task/
    /// </example>
    public sealed class HeyTapCustomTaskRequest : CustomTaskRequestBase
    {
        /// <inheritdoc/>
        public override string Class => "heytap";

        /// <summary>
        /// The value of the siteKey parameter found on the page.
        /// </summary>
        [JsonProperty("websiteKey", Required = Required.Always)]
        [StringLength(int.MaxValue, MinimumLength = 1)]
        public string WebsiteKey { get; set; }

        /// <summary>
        /// Initializes HeyTap task with optional metadata.
        /// </summary>
        ///
        /// <param name="apiServer">
        /// Subdomain of the HeyTap API server, specified only as a domain without the https:// prefix.
        /// Required only if it differs from the default API server.
        /// </param>
        public HeyTapCustomTaskRequest(string apiServer = null) => Metadata = new { apiServer };
    }
}
